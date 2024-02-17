using Microsoft.AspNetCore.Mvc;
using Mission06_Bangerter.Models;
using System.Diagnostics;

namespace Mission06_Bangerter.Controllers
{
    public class HomeController : Controller
    {
        private NewMovieContext _context;
        public HomeController(NewMovieContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            return View();
        }

        //get the responses and save them to the data base and then redirect the person to the same page
        [HttpPost]
        public IActionResult NewMovie(NewMovies response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View(response);
        }
    }
}
