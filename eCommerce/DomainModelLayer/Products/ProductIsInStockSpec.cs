using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Specification;

namespace eCommerce.DomainModelLayer.Products
{
    public class ProductIsInStockSpec : SpecificationBase<Product>
    {
        public override Expression<Func<Product, bool>> SpecExpression
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
