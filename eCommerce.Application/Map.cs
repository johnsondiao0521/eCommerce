using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using eCommerce.Application.Customers;
using eCommerce.Domain.Model.Customers;

namespace eCommerce.Application
{
    public class Map : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<CreditCard, CreditCardDto>();
            Mapper.CreateMap<Customer, CustomerDto>();
            //Mapper.CreateMap<Product, ProductDto>();
        }
    }
}
