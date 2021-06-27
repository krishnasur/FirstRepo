using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI.Controllers
{
    public class CustomersController : ApiController
    {
        
        [Route("api/Customers/GetCustomers")]
        public IEnumerable<Customer> GetCustomers()
        {
            using (KrishnaDBEntities2 krishnaDBEntities = new KrishnaDBEntities2())
            {
                //var clist= krishnaDBEntities.Customers.ToList();
                PostCustomers();
                return krishnaDBEntities.Customers.ToList();
            }
        }
        public void PostCustomers()
        {
            KrishnaDBEntities2 krishnaDBEntities = new KrishnaDBEntities2();
            //insert data into another table
            CustomersWrite customersWrite = new CustomersWrite();
            //customersWrite.CustomerID = 1;
            customersWrite.CustomerName = "test";
            customersWrite.ContactName = "test";
            customersWrite.City = "test";
            customersWrite.Address = "test";
            customersWrite.Country = "test";
            krishnaDBEntities.CustomersWrites.Add(customersWrite);
            krishnaDBEntities.SaveChanges();
        }

    }
}
