using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.Data.Models;
using MyWebSite.Data.ViewModels;
using MyWebSite.HorizontalClasses.Interfaces;
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
            ViewBag.Contact = await this._repos.ContactData.GetActive();
            return View(await this._repos.HomeData.GetActive());
        }

        public async Task<IActionResult> Resume()
        {
            ViewBag.Contact = await this._repos.ContactData.GetActive();
            var cv = await this._repos.CVs.GetActive();
            return View(cv);
        }

        public async Task<IActionResult> Portofolio()
        {
            ViewBag.Contact = await this._repos.ContactData.GetActive();
            var projects = await this._repos.Projects.GetAll();
            foreach (var project in projects)
            {
                if (project.Price != 0.00m)
                {
                    project.DownloadLinkZip = null;
                    project.DownloadLinkTar = null;
                }
            }
            return View(projects);
        }

        public async Task<IActionResult> Contact()
        {
            ViewBag.Contact = await this._repos.ContactData.GetActive();
            return View(await this._repos.ContactData.GetActive());
        }

        public async Task<ActionResult> _Details(int? id)
        {
            if (id == null)
                return BadRequest();
            var project = await this._repos.Projects.Get(id);
            if (project == null)
                return BadRequest();
            if (project.Price != 0.00m)
            {
                project.DownloadLinkZip = null;
                project.DownloadLinkTar = null;
            }
            return PartialView("_Details", project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Message(MessageViewModel message)
        {
            var messageDB = this._mapper.Map<Message>(message);
            if (!ModelState.IsValid)
            {
                ViewBag.Contact = await this._repos.ContactData.GetActive();
                return View("Contact", await this._repos.ContactData.GetActive());
            }
            if (message == null || message.Subject == null)
                return BadRequest();
            var subject = message.Subject.Length > 0 ? message.Subject : null;
            messageDB.Subject = "MyWebSite: " + subject;
            var title = messageDB.FullName;

            // Save Message
            await this._repos.Messages.Add(messageDB);
            await this._repos.Messages.Save();

            // Send Email
            await this._emailTool.Send(messageDB.MyMessage, messageDB.Subject, title);

            ViewBag.Contact = await this._repos.ContactData.GetActive();
            return View("Index", await this._repos.HomeData.GetActive());
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrder(OrderViewModel order)
        {
            var orderDB = this._mapper.Map<Order>(order);
            if(ModelState.IsValid)
            {
                order.Project = await this._repos.Projects.Get(order.ProjectId);
                await this._repos.Orders.Add(orderDB);
                await this._repos.Orders.Save();
                var orderViewModel = this._mapper.Map<OrderViewModel>(order);
                return PartialView("_Download", orderViewModel);
            }
            return Ok("Not Valid");
        }
    }
}
