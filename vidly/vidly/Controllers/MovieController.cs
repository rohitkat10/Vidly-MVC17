using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModel;

namespace vidly.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        //public ActionResult Index()
        //{
        //    var Movie = new Movie()
        //    {
        //        Name = "RockStar"
        //    };

        //    var Customer = new List<Customer>
        //    {
        //        new Customer{Name="Rohit1"},
        //        new Customer{Name="Rohit2"}

        //    };
        //    var ViewModel = new RandomMovieViewModel()
        //    {
        //        Movie = Movie,
        //        Customers = Customer

        //    };
        //   //foreach(var Customer in ViewModel. )
        //    return View(ViewModel);
        //}
        public ViewResult Index()
        {
            var Movie = GetMovies();
            return View(Movie);
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id=1,Name="RockStar"},
                new Movie{Id=2,Name="Rab ne banadi jodi"}
            };
           
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Rockstar" };
            var Customer = new List<Customer>
            {
                new Customer{Name="Rohit1"},
                new Customer{Name="Rohit2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = Customer
            };
            return View(viewModel);
        }
	}
}