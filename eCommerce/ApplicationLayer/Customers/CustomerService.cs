using System;
using System.Collections.Generic;
using eCommerce.DomainModelLayer.Countries;
using eCommerce.DomainModelLayer.Customers;
using eCommerce.Helpers.Repository;
using eCommerce.Helpers.Specification;

namespace eCommerce.ApplicationLayer.Customers
{
    public class CustomerService : ICustomerService
    {
        readonly ICustomerRepository customerRepository;
        readonly IRepository<Country> countryRepository;
        readonly IUnitOfWork unitOfWork;

        public CustomerService(ICustomerRepository customerRepository, IRepository<Country> countryRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.countryRepository = countryRepository;
            this.unitOfWork = unitOfWork;
        }
        public CustomerDto Add(CustomerDto customerDto)
        {
            ISpecification<Customer> alreadyRegisteredSpec = new CustomerAlreadyRegisteredSpec(customerDto.Email);

            var existingCustomer = this.customerRepository.FindOne(alreadyRegisteredSpec);

            if (existingCustomer != null)
                throw new Exception("Customer with this email already exists");

            var country = this.countryRepository.FindById(customerDto.CountryId);
            var customer = Customer.Create(customerDto.FirstName, customerDto.LastName, customerDto.Email, country);
            this.customerRepository.Add(customer);
            this.unitOfWork.Commit();

            return AutoMapper.Mapper.Map<Customer, CustomerDto>(customer);
        }

        public CreditCardDto Add(Guid customerId, CreditCardDto creditCardDto)
        {
            ISpecification<Customer> registeredSpec = new CustomerRegisteredSpec(customerId);

            Customer customer = this.customerRepository.FindOne(registeredSpec);

            if (customer == null)
                throw new Exception("No such customer exists");

            CreditCard creditCard = CreditCard.Create(customer, creditCardDto.NameOnCard, creditCardDto.CardNumber, creditCardDto.Expiry);

            customer.Add(creditCard);

            this.unitOfWork.Commit();

            return AutoMapper.Mapper.Map<CreditCard, CreditCardDto>(creditCard);
        }

        public CustomerDto Get(Guid customerId)
        {
            ISpecification<Customer> registeredSpec = new CustomerRegisteredSpec(customerId);

            Customer customer = this.customerRepository.FindOne(registeredSpec);

            return AutoMapper.Mapper.Map<Customer, CustomerDto>(customer);
        }

        public List<CustomerPurchaseHistoryDto> GetAllCustomerPurchaseHistoryV1()
        {
            throw new NotImplementedException();
        }

        public List<CustomerPurchaseHistoryDto> GetAllCustomerPurchaseHistoryV2()
        {
            throw new NotImplementedException();
        }

        public bool IsEmailAvailable(string email)
        {
            ISpecification<Customer> alreadyRegisteredSpec = new CustomerAlreadyRegisteredSpec(email);

            Customer existingCustomer = customerRepository.FindOne(alreadyRegisteredSpec);

            if (existingCustomer == null)
                return true;

            return false;
        }

        public void Remove(Guid customerId)
        {
            ISpecification<Customer> registeredSpec = new CustomerRegisteredSpec(customerId);

            var customer = this.customerRepository.FindOne(registeredSpec);
            if (customer == null)
                throw new Exception("No such cstomer exists");

            this.customerRepository.Remove(customer);
            this.unitOfWork.Commit();
        }

        public void Update(CustomerDto customerDto)
        {
            if (customerDto.Id == Guid.Empty)
                throw new Exception("Id can't be empty");

            ISpecification<Customer> registeredSpec = new CustomerRegisteredSpec(customerDto.Id);

            var customer = this.customerRepository.FindOne(registeredSpec);
            if (customer == null)
                throw new Exception("No such cstomer exists");

            customer.ChangeEmail(customerDto.Email);
            this.unitOfWork.Commit();
        }
    }
}
