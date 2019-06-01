using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Customers
{
    public interface ICustomerService
    {
        bool IsEmailAvailable(string email);
        CustomerDto Add(CustomerDto customerDto);

        void Update(CustomerDto customerDto);

        void Remove(Guid customerId);
        CustomerDto Get(Guid customerId);
        CreditCardDto Add(Guid customerId, CreditCardDto creditCardDto);
    }
}
