using BarkerAssignment9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Action for when Home/Index is called
        public IActionResult Index()
        {
            return View();
        }

        //Action for when Podcasts is called
        public IActionResult Podcasts()
        {
            return View();
        }

        //Action for when FilmForm is called
        public IActionResult FilmForm()
        {
            return View();
        }

        //Action for when the "submit" button is clicked on the FilmForm page
        [HttpPost]
        public IActionResult FilmForm(FormResponse appResponse)
        {
            TempStorage.AddResponse(appResponse);
            return View("Confirmation", appResponse);
        }

        public IActionResult CollectionList()
        {
            return View(TempStorage.Responses);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
