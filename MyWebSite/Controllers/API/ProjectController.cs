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
    public class ProjectController : ControllerBase
    {
        private readonly IRepositoriesHundler _repos;

        public ProjectController(IRepositoriesHundler repos)
        {
            this._repos = repos;
        }

        // GET: api/<ProjectController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await this._repos.Projects.GetAll());
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
                return BadRequest();
            try
            {
                return Ok(await this._repos.Projects.Get(id));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // POST api/<ProjectController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Project model)
        {
            if (model == null)
                return BadRequest();
            try
            {
                await this._repos.Projects.Add(model);
                await this._repos.Projects.Save();
                return Ok(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] Project model)
        {
            if (model == null)
                return BadRequest();
            try
            {
                this._repos.Projects.Update(model);
                await this._repos.Projects.Save();
                return Ok(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            try
            {
                await this._repos.Projects.Delete(id);
                await this._repos.Projects.Save();
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
