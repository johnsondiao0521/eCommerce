using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Customers
{
    public class CustomerService : ICustomerService
    {
        readonly ICustomerRepository customerRepository;
        readonly IRepository<Country> countryRepository;
        readonly IUnitOfWork unitOfWork;
        public CustomerDto Add(CustomerDto customerDto)
        {
            throw new NotImplementedException();
        }

        public CreditCardDto Add(Guid customerId, CreditCardDto creditCardDto)
        {
            throw new NotImplementedException();
        }

        public CustomerDto Get(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public bool IsEmailAvailable(string email)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerDto customerDto)
        {
            throw new NotImplementedException();
        }
    }
}
