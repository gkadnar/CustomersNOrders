using Custs.DAL;
using Custs.Model;
using Custs.Model.Common;

namespace Custs.Repository
{
    public class CustomerProfile : AutoMapper.Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerEntity, Customer>().ReverseMap();
            CreateMap<CustomerEntity, ICustomer>().ReverseMap();
            CreateMap<ICustomer, CustomerEntity>().ReverseMap();
        }
    }
}
