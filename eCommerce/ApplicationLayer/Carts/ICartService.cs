using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.ApplicationLayer.Carts
{
    public interface ICartService
    {
        CartDto Add(Guid customerId, CartProductDto cartProductDto);
        CartDto Remove(Guid customerId, Guid productId);
        CartDto Get(Guid customerId);
        CheckOutResultDto CheckOut(Guid customerId);
    }
}
