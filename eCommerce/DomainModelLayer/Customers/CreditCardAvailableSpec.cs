using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Specification;

namespace eCommerce.DomainModelLayer.Customers
{
    public class CreditCardAvailableSpec : SpecificationBase<CreditCard>
    {
        readonly DateTime dateTime;

        public CreditCardAvailableSpec(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public override Expression<Func<CreditCard, bool>> SpecExpression
        {
            get
            {
                return creditCard => creditCard.Active && creditCard.Expiry >= this.dateTime;
            }
        }
    }
}
