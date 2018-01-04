using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DomainModelLayer.Carts
{
    public enum CheckOutIssue
    {
        UnpaidBalance = 101,
        NoActiveCreditCardAvailable = 102,
        ProductNotInStock = 201,
        ProductIsFaulty = 202,
    }
}
