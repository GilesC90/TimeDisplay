using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace TimeDisplay.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.time = CurrentTime.ToString("MMMM dd yyyy hh:mm tt");
            return View();
        }
    }
}