using LetUsTest1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetUsTest1.Models;

namespace LetUsTest1.Controllers
{
    public class AppController : Controller
    {
        private readonly IPicsRepository _picRepository;

        public AppController(IPicsRepository picRepository)
        {
            _picRepository = picRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.Title = "Bob's Home Page";

            var pics = _picRepository.GetPics().OrderBy(p => p.Id);

            var pictures = new AppViewModels()
            {
                Pics = pics.ToList()
            };

            return View(pictures);
        }

        public IActionResult More(int Id)
        {
            ViewBag.Title = "More Information";
            var pic = _picRepository.GetPicById(Id);
            if (pic == null)
            {
                return NotFound();
            }
            return View(pic);
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Me";
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            ViewBag.Title = "Contact Me";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Page";
            return View();
        }
    }
}
