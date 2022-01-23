using Microsoft.AspNetCore.Mvc;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses.Interfaces;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IRepositoriesHundler _repos;

        public MessageController(IRepositoriesHundler repos)
        {
            this._repos = repos;
        }

        // GET: api/<MessageController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await this._repos.Messages.GetAll());
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // GET api/<MessageController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
                return BadRequest();
            try
            {
                return Ok(await this._repos.Messages.Get(id));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // POST api/<MessageController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Message model)
        {
            if (model == null)
                return BadRequest();
            try
            {
                await this._repos.Messages.Add(model);
                await this._repos.Messages.Save();
                return Ok(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // PUT api/<MessageController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] Message model)
        {
            if (model == null)
                return BadRequest();
            try
            {
                this._repos.Messages.Update(model);
                await this._repos.Messages.Save();
                return Ok(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // DELETE api/<MessageController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            try
            {
                await this._repos.Messages.Delete(id);
                await this._repos.Messages.Save();
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
