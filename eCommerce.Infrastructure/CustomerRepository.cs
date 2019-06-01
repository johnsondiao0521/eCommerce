using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using eCommerce.Domain.Model.Customers;

namespace eCommerce.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        protected static List<Customer> entities = new List<Customer>();

        public CustomerRepository()
        {
            var customer = Customer.Create(new Guid("5D5020DA-47DF-4C82-A722-C8DEAF06AE23"), "zhida", "diao", "zhida.diao@qq.com",
               Country.Create(new Guid("229074BD-2356-4B5A-8619-CDEBBA71CC21"), "CN Chinese"));

            customer.Add(CreditCard.Create(customer, "MR J SMITH", "123122131", DateTime.Today.AddDays(1)));

            entities.Add(customer);
        }
        public void Add(Customer entity)
        {
            entities.Add(entity);
        }

        public IEnumerable<Customer> Find(Func<Customer, bool> whereLambda)
        {
            return entities.Where(whereLambda);
        }

        public Customer FindById(Guid id)
        {
            return entities.FirstOrDefault(c => c.Id == id);
        }

        public Customer FindOne(Func<Customer, bool> whereLambda)
        {
            return entities.FirstOrDefault(whereLambda);
        }

        public void Remove(Customer entity)
        {
            entities.Remove(entity);
        }
    }
}
