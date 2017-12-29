using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Repository;

namespace eCommerce.DomainModelLayer.Customers
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        //IEnumerable<CustomerPurchaseHistoryReadModel> GetCustomersPurchaseHistory();
    }
}
