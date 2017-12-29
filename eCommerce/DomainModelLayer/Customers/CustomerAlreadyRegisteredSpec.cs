﻿using System;
using System.Linq.Expressions;
using eCommerce.Helpers.Specification;

namespace eCommerce.DomainModelLayer.Customers
{
    public class CustomerAlreadyRegisteredSpec : SpecificationBase<Customer>
    {
        string email;

        public CustomerAlreadyRegisteredSpec(string email)
        {
            this.email = email;
        }

        public override Expression<Func<Customer, bool>> SpecExpression
        {
            get
            {
                return customer => customer.Email == this.email;
            }
        }
    }
}
