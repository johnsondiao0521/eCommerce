using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Domain;

namespace eCommerce.DomainModelLayer.Purchases
{
    public class Purchase : IAggregateRoot
    {
        private List<PurchasedProduct> purchasedProducts = new List<PurchasedProduct>();

        public Guid Id { get; protected set; }
        public ReadOnlyCollection<PurchasedProduct> Products
        {
            get { return purchasedProducts.AsReadOnly(); }
        }
        public DateTime Created { get; protected set; }
        public Guid CustomerId { get; protected set; }
        public decimal TotalTax { get; protected set; }
        public decimal TotalCost { get; protected set; }
    }
}
