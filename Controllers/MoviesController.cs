using System.Collections.Generic;
using System.Web.Mvc;
using Video_Store_Web_App.Models;
using Video_Store_Web_App.ViewModels;

namespace Video_Store_Web_App.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "The Fish" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Fissiha"},
                new Customer {Name = "Abiti"}

            };
            // Creating view model object
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}