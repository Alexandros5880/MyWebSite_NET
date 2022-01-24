using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.Data.Models;
using MyWebSite.Data.ViewModels;
using MyWebSite.HorizontalClasses.Interfaces;
using System;
using System.Threading.Tasks;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoriesHundler _repos;
        private readonly IMapper _mapper;
        private readonly IEmailTool _emailTool;

        public HomeController(IRepositoriesHundler repos, IMapper mapper, IEmailTool emailTool)
        {
            this._repos = repos;
            this._mapper = mapper;
            this._emailTool = emailTool;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Resume()
        {
            var cv = await this._repos.CVs.GetActive();
            return View(cv);
        }

        public async Task<IActionResult> Portofolio()
        {
            var projects = await this._repos.Projects.GetAll();
            return View(projects);
        }

        public async Task<IActionResult> Contact()
        {
            return View();
        }

        public async Task<ActionResult> _Details(int? id)
        {
            if (id == null)
                return BadRequest();
            var project = await this._repos.Projects.Get(id);
            if (project == null)
                return BadRequest();
            return PartialView("_Details", project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Message(MessageViewModel message)
        {
            if (message == null)
                return BadRequest();
            try
            {
                //throw new Exception();
                var messageDB = this._mapper.Map<Message>(message);

                var subject = message.Subject.Length > 0 ? message.Subject : null;
                messageDB.Subject = "MyWebSite: " + subject;
                var title = messageDB.FullName;

                // Save Message
                await this._repos.Messages.Add(messageDB);
                await this._repos.Messages.Save();

                // Send Email
                await this._emailTool.Send(messageDB.MyMessage, messageDB.Subject, title);

                return View("Index");
            }
            catch (Exception)
            {
                ViewBag.Error = "Somthing wrong was happend, Please try again!";
                return View("Contact");
            }
        }
    }
}
