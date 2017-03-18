using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        public ViewResult Index()
        {
            var Customer =  GetCustomer();
            return View(Customer);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer{Id=1,Name="Rohit1"},
                new Customer{Id=2,Name="Rohit2"}
            };
        }
	}
}