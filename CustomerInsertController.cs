﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BalLibrary;
using DalLibrary;
using ProjectWebApplication.Models;

namespace ProjectWebApplication.Controllers
{
    public class CustomerInsertController : ApiController
    {
        public IHttpActionResult CustomerInsert(InsertCustModel cust)
        {
            DalLayer ds = new DalLayer();
            CustomerBAL ba = new CustomerBAL();
          
            ba.EmailId = cust.EmailId;
            ba.Password = cust.Password;
            ba.FirstName = cust.FirstName;
            ba.LastName = cust.LastName;
            ba.MobileNo = cust.MobileNo;
            ba.City = cust.City;
            
            string s1= ds.AddCustomer(ba);
            return Ok(new { status = 200, isSuccess = true, message = "ur logged sucess", });

        }
    }
}
