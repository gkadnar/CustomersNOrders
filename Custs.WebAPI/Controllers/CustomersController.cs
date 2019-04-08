using Custs.Model;
using Custs.Model.Common;
using Custs.Service.Common;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

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

        [HttpGet]
        [Route("getall")]
        public async Task<IEnumerable<ICustomer>> GetAllCustomers()
        {
            return await Service.GetAllCustomers();
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public async Task<ICustomer> GetCustomerById(long id)
        {
            return await Service.GetCustomerById(id);
        }

        [HttpGet]
        [Route("deletebyid/{id}")]
        public Task<StatusCodeResult> DeleteCustomerById(long id)
        {
            Service.DeleteCustomerById(id);
            return Task.FromResult(StatusCode(HttpStatusCode.OK));
        }

        [HttpPost]
        [Route("createcustomer")]
        public Task<StatusCodeResult> AddCustomer([FromBody] Customer customer)
        {
            Service.CreateCustomer(customer);
            return Task.FromResult(StatusCode(HttpStatusCode.Created));
        }

        [HttpPost]
        [Route("updatecustomer")]
        public Task<StatusCodeResult> UpdateCustomer([FromBody] Customer customer)
        {
            Service.UpdateCustomer(customer);
            return Task.FromResult(StatusCode(HttpStatusCode.OK));
        }

        public string GetTest()
        {
            return "gkadnar";
        }

    }
}