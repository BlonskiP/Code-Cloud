using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CodeAndCloud.ViewModel;
using Microsoft.AspNetCore.Mvc;
using CodeAndCloud.Services;

namespace Cloud.Controllers
{
    public class HomeController : Controller
    {
        private IContactService _service;
        public HomeController(IContactService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(AddContactViewModel model)
        {
            _service.Add(model);
            return View();
        }
        
    }
}
