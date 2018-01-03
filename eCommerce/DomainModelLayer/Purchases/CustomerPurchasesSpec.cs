using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Specification;

namespace eCommerce.DomainModelLayer.Purchases
{
    public class CustomerPurchasesSpec : SpecificationBase<Purchase>
    {
        readonly Guid customerId;

        public CustomerPurchasesSpec(Guid customerId)
        {
            this.customerId = customerId;
        }

        public override Expression<Func<Purchase, bool>> SpecExpression
        {
            get
            {
                return purchase => purchase.CustomerId == this.customerId;
            }
        }
    }
}
