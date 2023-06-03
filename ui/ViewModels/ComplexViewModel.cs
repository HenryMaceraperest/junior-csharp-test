using System;
using System.Linq;
using System.Windows.Forms;
using ui.DataAccess;
using ui.Models;

namespace ui.ViewModels
{
    public class ComplexViewModel
    {
        private readonly DatabaseContext dbContext;
        public ComplexViewModel()
        {
            dbContext = new DatabaseContext();
            LoadOrderNumbers();
        }

        private int[] orderNumbers;
        public int[] OrderNumbers
        {
            get
            {
                return orderNumbers;
            }
            set
            {
                orderNumbers = value;
            }
        }
        private OrderModel orderDetailModel;
        public OrderModel OrderDetailModel
        {
            get
            {
                return orderDetailModel;
            }
            set
            {
                orderDetailModel = value;
            }
        }


        private void LoadOrderNumbers()
        {
            try
            {
                orderNumbers = GetOrderNumbers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        public void LoadSearchOrderNumbers(DateTime? startDate = null, DateTime? endDate = null, string orderNumber = "")
        {
            try
            {
                int[] ordersFromDb = GetOrderNumbers(startDate, endDate, orderNumber);
                orderNumbers = ordersFromDb;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while searching. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetComplexDetailedViewOrder(string id)
        {
            try
            {
                orderDetailModel = GetOrderDetails(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while searching. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private OrderModel GetOrderDetails(string id)
        {
            string query = @"SELECT o.order_number, o.customer_number, o.sale_price, o.deposit, o.order_date, 
                             c.customer_number, c.forename as customer_forename, c.surname as customer_surname, c.telephone_number as customer_phone, 
                             e.employee_number, e.branch_name, e.line_manager_number, e.forename as employee_forename, e.surname as employee_surname, 
                             b.branch_name, b.postcode 
                             FROM orders AS o 
                             LEFT JOIN customers AS c ON o.customer_number = c.customer_number 
                             LEFT JOIN employees AS e ON o.employee_number = e.employee_number 
                             LEFT JOIN branches AS b ON e.branch_name = b.branch_name WHERE o.order_number = '" + id + "'";

            OrderModel order = dbContext.GetOrderDetailsFromDb(query);
            return order;
        }

        private int[] GetOrderNumbers(DateTime? startDate = null, DateTime? endDate = null, string orderNumber = "")
        {
            string query = @"SELECT order_number FROM orders";

            if (!string.IsNullOrWhiteSpace(orderNumber))
            {
                query += $" WHERE order_number LIKE '%{orderNumber}%'";

                if (startDate.HasValue && endDate.HasValue)
                {
                    query += $" AND order_date BETWEEN '{startDate.Value.ToString("yyyy-MM-dd")}' AND '{endDate.Value.ToString("yyyy-MM-dd")}'";
                }
                else if (startDate.HasValue)
                {
                    query += $" AND order_date >= '{startDate.Value.ToString("yyyy-MM-dd")}'";
                }
                else if (endDate.HasValue)
                {
                    query += $" AND order_date <= '{endDate.Value.ToString("yyyy-MM-dd")}'";
                }
            }
            else
            {
                if (startDate.HasValue && endDate.HasValue)
                {
                    query += $" WHERE order_date BETWEEN '{startDate.Value.ToString("yyyy-MM-dd")}' AND '{endDate.Value.ToString("yyyy-MM-dd")}'";
                }
                else if (startDate.HasValue)
                {
                    query += $" WHERE order_date >= '{startDate.Value.ToString("yyyy-MM-dd")}'";
                }
                else if (endDate.HasValue)
                {
                    query += $" WHERE order_date <= '{endDate.Value.ToString("yyyy-MM-dd")}'";
                }
            }
            query += " ORDER BY order_number ASC";

            int[] orderNumbers = dbContext.GetOrderNumbersFromDb(query);
            return orderNumbers;
        }
    }
}
