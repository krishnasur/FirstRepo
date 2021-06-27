﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class Customers
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }


    }
}