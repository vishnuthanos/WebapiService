using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _2nd.Controllers
{
    public class TicketController : ApiController
    {
        [HttpGet]

        [AllowAnonymous]

        [Route("api/Customer/GetCustomers")]
        public IHttpActionResult GetCustomers()
        {
            var db = new EmployeeDBEntities1();
            var customers = db.Customers.ToList();
            return Ok(customers);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Customer/SaveCustomer")]
        public IHttpActionResult SaveCustomer(Customer customer)
        {
            if (customer.Id > 0)
            {
                var db = new EmployeeDBEntities1();
                var dbCustomer = db.Customers.FirstOrDefault(x => x.Id == customer.Id);
                dbCustomer.Name = customer.Name;
                dbCustomer.Address = customer.Address;
                dbCustomer.Phone = customer.Phone;
                db.SaveChanges();
            }
            else
            {
                var db = new EmployeeDBEntities1();
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            return Ok(customer.Id);
        }

        [HttpDelete]
        [AllowAnonymous]
        [Route("api/Customer/DeleteCustomer/{id}")]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var db = new EmployeeDBEntities1();
            var customer = new Customer { Id = id };
            db.Customers.Attach(customer);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return Ok(id);
        }
    }
}
