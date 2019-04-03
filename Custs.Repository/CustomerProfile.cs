using Custs.DAL;
using Custs.Model;
using Custs.Model.Common;

namespace Custs.Repository
{
    public class CustomerProfile : AutoMapper.Profile
    {
        public CustomerProfile()
        {
            CreateMap<IOrder, Order>().ReverseMap();
            CreateMap<OrderEntity, IOrder>().ReverseMap();
            CreateMap<IOrder, OrderEntity>().ReverseMap();

            CreateMap<ICustomer, Customer>().ReverseMap();
            CreateMap<CustomerEntity, ICustomer>().ReverseMap();
            CreateMap<ICustomer, CustomerEntity>()
                .ForMember(dest => dest.Orders, opt => opt.Ignore())
                .ReverseMap()
                .ForSourceMember(src => src.Orders, opt => opt.DoNotValidate());

            /*
            CreateMap<CustomerEntity, Customer>()
                .ForMember(model => model.Email, opt => opt.MapFrom(entity => entity.Email))
                .ForMember(model => model.Name, opt => opt.MapFrom(entity => entity.Name))
                .ForMember(model => model.Id, opt => opt.MapFrom(entity => entity.Id));
                */
            /*
                    .ForMember(dto => dto.City, opt => opt.MapFrom(product => product.City))
                    .ForMember(dto => dto.Category, opt => opt.MapFrom(product => product.Category.ParentCategory.Name))
                    .ForMember(dto => dto.Subcategory, opt => opt.MapFrom(product => product.Category.Name));
            */

        }
    }
}
