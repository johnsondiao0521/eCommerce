using System;
using System.Linq.Expressions;
using eCommerce.Helpers.Specification;

namespace eCommerce.DomainModelLayer.Carts
{
    public class CustomerCartSpec : SpecificationBase<Cart>
    {
        readonly Guid customerId;

        public CustomerCartSpec(Guid customerId)
        {
            this.customerId = customerId;
        }

        public override Expression<Func<Cart, bool>> SpecExpression
        {
            get
            {
                return cart => cart.CustomerId == this.customerId;
            }
        }
    }
}
