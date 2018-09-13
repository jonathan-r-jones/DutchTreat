using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            //throw new InvalidOperationException("bad stuff");
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
