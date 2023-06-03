using System;

namespace ui.Models
{
    public class OrderModel
    {
        public int OrderNumber { get; set; }
        public CustomerModel Customer { get; set; }
        public EmployeeModel Employee { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Deposit { get; set; }
        public DateTime OrderDate { get; set; }

        public bool HasOrderNumber()
        {
            if (OrderNumber != null)
            {
                return true;
            }
            else
            {
                return false;
            };
    }
    }
}
