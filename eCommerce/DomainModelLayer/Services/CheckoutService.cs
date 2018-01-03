
using eCommerce.DomainModelLayer.Customers;
using eCommerce.DomainModelLayer.Products;
using eCommerce.DomainModelLayer.Purchases;
using eCommerce.Helpers.Domain;
using eCommerce.Helpers.Repository;

namespace eCommerce.DomainModelLayer.Services
{
    public class CheckoutService : IDomainService
    {
        ICustomerRepository customerRepository;
        IRepository<Purchase> purchaseRepository;
        IRepository<Product> productRepository;

        public CheckoutService(ICustomerRepository customerRepository, IRepository<Purchase> purchaseRepository, IRepository<Product> productRepository)
        {
            this.customerRepository = customerRepository;
            this.purchaseRepository = purchaseRepository;
            this.productRepository = productRepository;
        }
    }
}
