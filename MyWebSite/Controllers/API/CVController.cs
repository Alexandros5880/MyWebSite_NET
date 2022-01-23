using Microsoft.AspNetCore.Mvc;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses.Interfaces;
using System;
using System.Threading.Tasks;

namespace MyWebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVController : ControllerBase
    {
        private readonly IRepositoriesHundler _repos;

        public CVController(IRepositoriesHundler repos)
        {
            this._repos = repos;
        }

        // GET: api/<CVController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await this._repos.CVs.GetAll());
            } catch(Exception )
            {
                return NotFound();
            }
        }

        // GET api/<CVController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
                return BadRequest();
            try
            {
                return Ok(await this._repos.CVs.Get(id));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // POST api/<CVController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CV model)
        {
            if (model == null)
                return BadRequest();
            try
            {
                await this._repos.CVs.Add(model);
                await this._repos.CVs.Save();
                return Ok(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // PUT api/<CVController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] CV model)
        {
            if (model == null)
                return BadRequest();
            try
            {
                this._repos.CVs.Update(model);
                await this._repos.CVs.Save();
                return Ok(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // DELETE api/<CVController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            try
            {
                await this._repos.CVs.Delete(id);
                await this._repos.CVs.Save();
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
