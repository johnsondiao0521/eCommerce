using System;
using System.Linq.Expressions;
using eCommerce.DomainModelLayer.Products;
using eCommerce.Helpers.Specification;

namespace eCommerce.DomainModelLayer.Carts
{
    public class ProductInCartSpec : SpecificationBase<CartProduct>
    {
        readonly Product product;

        public ProductInCartSpec(Product product)
        {
            this.product = product;
        }

        public override Expression<Func<CartProduct, bool>> SpecExpression
        {
            get
            {
                return cartProduct => cartProduct.ProductId == this.product.Id;
            }
        }
    }
}
