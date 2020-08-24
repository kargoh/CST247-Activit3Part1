using Activity3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity3.Controllers
{
    public class CustomerController : Controller
    {

        CustomerModel customer;
        List<CustomerModel> customers;

        public CustomerController()
        {
            customers = new List<CustomerModel>();
            customers.Add(new CustomerModel(0, "Nick", 56));
            customers.Add(new CustomerModel(1, "Ben", 33));
            customers.Add(new CustomerModel(2, "Derrick", 31));
            customers.Add(new CustomerModel(3, "Jacob", 29));
            customers.Add(new CustomerModel(4, "Josh", 27));
            customers.Add(new CustomerModel(5, "Elijah", 21));
            customers.Add(new CustomerModel(6, "Isaiah", 21));
        }


        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple;
            tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[2]);

            return View("CustomerView", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string customerNumber)
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple;
            tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[Int32.Parse(customerNumber)]);

            return PartialView("_CustomerDetails", customers[Int32.Parse(customerNumber)]);
        }
    }
}