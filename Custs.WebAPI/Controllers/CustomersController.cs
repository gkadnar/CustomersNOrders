using Custs.Common.Filters;
using Custs.Model;
using Custs.Model.Common;
using Custs.Service.Common;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace Custs.WebAPI.Controllers
{

    /// <summary>
    /// /api/customers endpoint
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomersController : ApiController
    {

        protected ICustomerService Service { get; private set; }
        public CustomersController(ICustomerService service)
        {
            this.Service = service;
        }

        /// <summary>
        /// GET /api/customers
        /// Retrieve all customers : TODO make retrieve pageable and sortable
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<HttpResponseMessage> GetAllCustomers()
        {
            var res = await Service.GetAllCustomersAsync();
            return Request.CreateResponse(HttpStatusCode.OK,res);
        }

        [HttpGet]
        public async Task<HttpResponseMessage> GetAllCustomers(string searchCustomer, int pageNumber = 1, int pageSize = 10, string ordering = "Name")
        {
            CustomersFilter cFilter = new CustomersFilter(pageNumber,pageSize, ordering, searchCustomer);
            var res = await Service.GetAllCustomersAsync(cFilter);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }

        /// <summary>
        /// GET /api/customers/{id}
        /// Retrieve customer by Id  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<HttpResponseMessage> GetCustomerById(long id)
        {
            var res = await Service.GetCustomerByIdAsync(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }

        /// <summary>
        /// DELETE /api/customers/{id} 
        /// Delete customer by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<HttpResponseMessage> DeleteCustomerById([FromUri]long id)
        {
            var res = await Service.DeleteCustomerByIdAsync(new long[] { id });
            if (res >=1)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        /// <summary>
        /// Create customer endpoint
        /// POST /api/customers
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<HttpResponseMessage> AddCustomer([FromBody] Customer[] customers)
        {
            if (customers == null || (customers != null && customers.Length == 0))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var res = await Service.CreateCustomerAsync(customers);
            return Request.CreateResponse(HttpStatusCode.Created,res);
        }

        /// <summary>
        /// Update customer endpoint
        /// PUT /api/customers
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<HttpResponseMessage> UpdateCustomer([FromUri]int id, [FromBody] Customer customer)
        {
            var res = await Service.UpdateCustomerAsync(id,customer);
            return Request.CreateResponse(HttpStatusCode.OK,res);
        }

    }
}