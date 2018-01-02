using AutoMapper;
using eCommerce.ApplicationLayer.Customers;
using eCommerce.DomainModelLayer.Customers;
using eCommerce.DomainModelLayer.Products;

namespace eCommerce.ApplicationLayer
{
    public class Map : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<CreditCard, CreditCardDto>();
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Product, ProductDto>();
        }
    }
}
