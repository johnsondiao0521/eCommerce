using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Specification;

namespace eCommerce.DomainModelLayer.Products
{
    public class ProductReturnReasonSpec : SpecificationBase<Product>
    {
        readonly ReturnReason returnReason;

        public ProductReturnReasonSpec(ReturnReason returnReason)
        {
            this.returnReason = returnReason;
        }

        public override Expression<Func<Product, bool>> SpecExpression
        {
            get
            {
                return product => product.Returns.ToList().Exists(returns => returns.Reason == this.returnReason);
            }
        }
    }
}
