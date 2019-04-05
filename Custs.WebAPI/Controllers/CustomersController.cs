using Custs.Model.Common;
using Custs.Service.Common;
using System;
using System.Collections.Generic;
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
        public Task<OkResult> DeleteCustomerById(long id)
        {
            Service.DeleteCustomerById(id);
            return Task.FromResult(Ok());
        }


        public string GetTest()
        {
            return "gkadnar";
        }

    }
}