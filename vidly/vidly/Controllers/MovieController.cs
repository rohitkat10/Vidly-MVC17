using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using vidly.Models;
using vidly.ViewModel;

namespace vidly.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var Movies = _context.Movie.Include(m => m.Genre).ToList();
            return View(Movies);
        }
        public ActionResult Details(int Id)
        {
            var Movie = _context.Movie.Include(m => m.Genre).SingleOrDefault(m => m.Id == Id);
            if (Movie == null)
                return HttpNotFound();
            return View(Movie);

        }
        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie{Id=1,Name="RockStar"},
        //        new Movie{Id=2,Name="Rab ne banadi jodi"}
        //    };
           
        //}
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