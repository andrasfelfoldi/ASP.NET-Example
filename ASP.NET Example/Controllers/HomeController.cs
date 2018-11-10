using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_Example.Models;
using ASP.NET_Example.Services;
using ASP.NET_Example.ViewModels;

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
            var model = new IndexModel();
            model.Movies= _movieDb.GetMovies();
            Console.Out.WriteLine(model.Movies == null);
            return View(model);
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

        [HttpGet]
        public IActionResult EditMovie(int id)
        {
            Movie movie=_movieDb.GetMovie(id);

            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMovie(Movie editedMovie)
        {
            _movieDb.EditMovie(editedMovie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteMovie(int id)
        {
            _movieDb.DeleteMovie(id);

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
