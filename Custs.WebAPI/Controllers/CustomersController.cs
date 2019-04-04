﻿using Custs.Model.Common;
using Custs.Service.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Custs.WebAPI.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {

        protected ICustomerService Service { get; private set; }
        public CustomersController(ICustomerService service)
        {
            this.Service = service;
        }

        // GET api/values
        public List<ICustomer> GetAllCustomers()
        {
            return Service.GetAllCustomers();
        }

        public string GetTest()
        {
            return "gkadnar";
        }

    }
}