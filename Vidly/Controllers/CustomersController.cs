using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new MovieCustomersViewModel()
            {               
                Customers = new List<Customer>
                {
                    new Customer(){Id = 1, Name = "John Smith"},
                    new Customer(){Id = 2, Name = "Mary Williams"}
                }
            };

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = new MovieCustomersViewModel()
            {
                Customers = new List<Customer>
                {
                    new Customer(){Id = 1, Name = "John Smith"},
                    new Customer(){Id = 2, Name = "Mary Williams"}
                }
            };

            Customer customerDetail = new Customer();
            if(customers.Customers.Count == 0)
                customerDetail.Id = -1;
            foreach(var customer in customers.Customers)
            {
                if (customer.Id == id)
                    customerDetail = customer;
            }
            if (customerDetail.Name.Length < 1)
                return new HttpNotFoundResult();

            return View(customerDetail);
        }
    }
}