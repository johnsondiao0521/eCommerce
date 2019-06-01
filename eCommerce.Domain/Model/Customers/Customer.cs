using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Model.Customers
{
    public class Customer : IAggregateRoot
    {
        private List<CreditCard> creditCards = new List<CreditCard>();
        public virtual Guid Id { get; protected set; }
        public virtual string FirstName { get; protected set; }
        public virtual string LastName { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Password { get; protected set; }
        public virtual decimal Balance { get; protected set; }
        public virtual Guid CountryId { get; protected set; }

        public virtual ReadOnlyCollection<CreditCard> CreditCards { get { return creditCards.AsReadOnly(); } }

        public virtual void ChangeEmail(string email)
        {
            if (Email != email)
            {
                this.Email = email;
                DomainEvents.Raise<CustomerChangedEmail>(new CustomerChangedEmail() { Customer = this });
            }
        }

        public static Customer Create(string firstname, string lastname, string email, Country country)
        {
            return Create(Guid.NewGuid(), firstname, lastname, email, country); ;
        }

        public static Customer Create(Guid id, string firstname, string lastname, string email, Country country)
        {
            if (string.IsNullOrEmpty(firstname))
                throw new ArgumentNullException("firstname");

            if (string.IsNullOrEmpty(lastname))
                throw new ArgumentNullException("lastname");

            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException("email");

            if (country == null)
                throw new ArgumentNullException("country");

            var customer = new Customer()
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                CountryId = country.Id
            };

            DomainEvents.Raise<CustomerCreated>(new CustomerCreated() { Customer = customer });

            return customer;
        }

        public virtual void Add(CreditCard creditCard)
        {
            this.creditCards.Add(creditCard);

            DomainEvents.Raise(new CreditCardAdded() { CreditCard = creditCard });
        }
    }
}
