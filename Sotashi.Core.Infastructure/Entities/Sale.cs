using Sotashi.Core.Infastructure.Contract;
using System;

namespace Sotashi.Core.Infastructure.Entities
{
    public class Sale : AuditableEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public double Price { get; set; }
    }
}
