using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Specification;

namespace eCommerce.DomainModelLayer.Purchases
{
    public class PurchasedNProductsSpec : SpecificationBase<Purchase>
    {
        readonly int nProducts;

        public PurchasedNProductsSpec(int nProducts)
        {
            this.nProducts = nProducts;
        }

        public override Expression<Func<Purchase, bool>> SpecExpression
        {
            get
            {
                return purchase => purchase.Products.Count >= this.nProducts;
            }
        }
    }
}
