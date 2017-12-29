﻿using System;

namespace eCommerce.ApplicationLayer.Customers
{
    public class CreditCardDto
    {
        public Guid Id { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public DateTime Expiry { get; set; }
    }
}
