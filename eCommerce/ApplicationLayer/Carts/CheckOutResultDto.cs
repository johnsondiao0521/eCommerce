using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.DomainModelLayer.Carts;

namespace eCommerce.ApplicationLayer.Carts
{
    public class CheckOutResultDto
    {
        public Nullable<Guid> PurchaseId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalTax { get; set; }
        public Nullable<CheckOutIssue> CheckOutIssue { get; set; }
    }
}
