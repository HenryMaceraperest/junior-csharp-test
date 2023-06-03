using System;

namespace ui.Models
{
    public class InvoiceModel
    {
        public string InvoiceNumber { get; set; }
        public OrderModel Order { get; set; }
        public decimal InvoiceValue { get; set; }
        public DateTime SettlementDate { get; set; }
    }
}
