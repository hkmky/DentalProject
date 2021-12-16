using Dental.Entities.Enums;
using Dental.Entities.Tables.Base;

namespace Dental.Entities.Tables
{
    public class Payment : EntityBase
    {
        public PaymentType PaymentType { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
