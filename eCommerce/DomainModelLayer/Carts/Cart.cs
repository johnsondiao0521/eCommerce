using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Domain;

namespace eCommerce.DomainModelLayer.Carts
{
    public class Cart : IAggregateRoot
    {
        public virtual Guid Id { get; protected set; }
        private List<CartProduct> cartProducts = new List<CartProduct>();
    }
}
