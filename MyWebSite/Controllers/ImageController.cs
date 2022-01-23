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
    public class ImageController : ControllerBase
    {
        private readonly IRepositoriesHundler _repos;

        public ImageController(IRepositoriesHundler repos)
        {
            this._repos = repos;
        }

        // GET: api/<ImageController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await this._repos.Images.GetAll());
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // GET api/<ImageController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
                return BadRequest();
            try
            {
                return Ok(await this._repos.Images.Get(id));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // POST api/<ImageController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Image model)
        {
            if (model == null)
                return BadRequest();
            try
            {
                await this._repos.Images.Add(model);
                await this._repos.Images.Save();
                return Ok(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // PUT api/<ImageController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] Image model)
        {
            if (model == null)
                return BadRequest();
            try
            {
                this._repos.Images.Update(model);
                await this._repos.Images.Save();
                return Ok(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // DELETE api/<ImageController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            try
            {
                await this._repos.Images.Delete(id);
                await this._repos.Images.Save();
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
