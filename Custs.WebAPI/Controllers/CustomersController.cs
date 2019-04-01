using Custs.Model.Common;
using Custs.Service.Common;
using System.Collections.Generic;
using System.Web.Http;

namespace Custs.WebAPI.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        private readonly ICustomerService _service;

        public CustomersController(ICustomerService service)
        {
            this._service = service;
        }

        // GET api/values
        public IEnumerable<ICustomer> GetCustomers()
        {
            //return new string[] { "value1", "value2" };
            return _service.GetAllCustomers();
        }

    }
}
