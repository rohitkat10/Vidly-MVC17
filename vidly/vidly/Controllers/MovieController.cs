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
        public ActionResult Index()
        {
            var Movie = new Movie()
            {
                Name = "RockStar"
            };

            var Customer = new List<Customer>
            {
                new Customer{Name="Rohit1"},
                new Customer{Name="Rohit2"}

            };
            var ViewModel = new RandomMovieViewModel()
            {
                Movie = Movie,
                Customers = Customer

            };
           //foreach(var Customer in ViewModel. )
            return View(ViewModel);
        }
	}
}