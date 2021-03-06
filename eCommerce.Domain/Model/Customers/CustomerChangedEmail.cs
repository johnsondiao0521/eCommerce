﻿
namespace eCommerce.Domain.Model.Customers
{
    public class CustomerChangedEmail : DomainEvent
    {
        public Customer Customer { get; set; }
        public override void Flatten()
        {
            this.Args.Add("CustomerId", Customer.Id);
            this.Args.Add("Email", Customer.Email);
        }
    }
}
