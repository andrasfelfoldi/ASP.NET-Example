using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_Example.Models;
using ASP.NET_Example.Services;

namespace ASP.NET_Example.Controllers
{
    public class HomeController : Controller
    {
        private IMovieDbService _movieDb;

        public HomeController(IMovieDbService movieDb)
        {
            _movieDb = movieDb;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMovie(Movie newMovie)
        {
            _movieDb.AddMovie(newMovie);
            return RedirectToAction(nameof(Index));
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
