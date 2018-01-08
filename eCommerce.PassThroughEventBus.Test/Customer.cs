using System;

namespace eCommerce.PassThroughEventBus.Test
{
    public class Customer
    {
        public Customer()
            : this(Guid.NewGuid(), null)
        { }

        public Customer(string name)
            : this(Guid.NewGuid(), name) { }

        public Customer(Guid id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
