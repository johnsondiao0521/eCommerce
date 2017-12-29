using System;
using System.Collections.Generic;
using eCommerce.DomainModelLayer.Countries;
using eCommerce.DomainModelLayer.Customers;
using eCommerce.Helpers.Specification;

namespace eCommerce.InfrastructureLayer
{
    public sealed class StubDataCustomerRepository : ICustomerRepository
    {
        readonly MemoryRepository<Customer> memRepository;

        public StubDataCustomerRepository(MemoryRepository<Customer> memRepository)
        {
            this.memRepository = memRepository;

            Customer customer = Customer.Create(new Guid("5D5020DA-47DF-4C82-A722-C8DEAF06AE23"), "zhida", "diao", "zhida.diao@qq.com",
               Country.Create(new Guid("229074BD-2356-4B5A-8619-CDEBBA71CC21"), "CN Chinese"));

            customer.Add(CreditCard.Create(customer, "MR J SMITH", "123122131", DateTime.Today.AddDays(1)));

            this.memRepository.Add(customer);
        }
        public void Add(Customer entity)
        {
            memRepository.Add(entity);
        }

        public IEnumerable<Customer> Find(ISpecification<Customer> spec)
        {
            return memRepository.Find(spec);
        }

        public Customer FindById(Guid id)
        {
            return memRepository.FindById(id);
        }

        public Customer FindOne(ISpecification<Customer> spec)
        {
            return memRepository.FindOne(spec);
        }

        public void Remove(Customer entity)
        {
            memRepository.Remove(entity);
        }
    }
}
