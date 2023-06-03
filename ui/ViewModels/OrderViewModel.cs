using System;
using System.Collections.Generic;
using ui.Models;
using ui.DataAccess;
using System.Data;
using System.Linq;
using System.Collections.ObjectModel;
using Microsoft.Extensions.Logging;
using System.Windows.Forms;

namespace ui.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {
            dbContext = new DatabaseContext();
        }
        private List<OrderModel> cachedOrders;
        private readonly DatabaseContext dbContext;
        public int pageSize { get; set; } = 100;
        
        private ObservableCollection<OrderModel> ordersForDisplay;
        public ObservableCollection<OrderModel> OrdersForDisplay
        {
            get 
            {
                if (ordersForDisplay == null || !ordersForDisplay.Any())
                {
                    LoadData();
                }
                return ordersForDisplay;
            }            
            set
            {
                ordersForDisplay = value;
            }
        }
        public ObservableCollection<OrderModel> OrdersForSearchDisplay
        {
            get { return ordersForDisplay; }
        }

        private int currentPage;
        public int CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
            }
        }
        public int PageSize
        {
            get { return pageSize; }
            set
            {
                pageSize = value;
            }
        }
        private int totalPages;
        public int TotalPages
        {
            get { return totalPages; }
        }
        private int totalOrders;
        public int TotalOrders
        {
            get { return totalOrders; }
            set
            {
                totalOrders = value;
            }
        }

        public string[] ColumnHeaders { get; } = { "Order Number", "Order Date", "Sale Price", "Deposit", "Customer #", "Customer Forename", "Customer Surname", "Customer Phone", "Branch Name", "Branch Postcode"};
        public int[] PageSizesSelection { get; } = { 25, 50, 100, 200, 300, 500 };

        public void LoadSearchData(DateTime? dateFrom = null, DateTime? dateTo = null, string id = null)
        {
            try
            {
                List<OrderModel> ordersFromDb = GetOrders(dateFrom, dateTo, id);

                currentPage = 0;

                totalOrders = ordersFromDb.Count;

                cachedOrders = new List<OrderModel>(ordersFromDb);

                RefreshOrdersForDisplay();

                totalPages = (int)Math.Ceiling((double)ordersFromDb.Count / PageSize);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading data. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadData()
        {
            try
            {
                List<OrderModel> ordersFromDb = GetOrders();

                totalOrders = ordersFromDb.Count;

                cachedOrders = new List<OrderModel>(ordersFromDb);

                RefreshOrdersForDisplay();

                totalPages = (int)Math.Ceiling((double)ordersFromDb.Count / PageSize);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading data. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void NextPage()
        {
            if ((currentPage + 1) < totalPages && totalOrders != 0)
            {
                CurrentPage++;
                RefreshOrdersForDisplay();
            }
        }

        public void PrevPage()
        {
            if (CurrentPage > 0 && totalOrders != 0)
            {
                CurrentPage--;
                RefreshOrdersForDisplay();
            }
        }

        private void RefreshOrdersForDisplay()
        {
            try
            {
                int startIndex = CurrentPage * pageSize;

                List<OrderModel> displayedOrders = cachedOrders.Skip(startIndex).Take(pageSize).ToList();

                ordersForDisplay = new ObservableCollection<OrderModel>(displayedOrders);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong with refreshing the orders. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private List<OrderModel> GetOrders(DateTime? startDate = null, DateTime? endDate = null, string orderNumber = "") 
        {
            string query = @"SELECT o.order_number, o.customer_number, o.sale_price, o.deposit, o.order_date, 
                             c.forename as customer_forename, c.surname as customer_surname, c.telephone_number as customer_phone, 
                             e.employee_number, e.line_manager_number, e.forename as employee_forename, e.surname as employee_surname, 
                             b.branch_name, b.postcode 
                             FROM orders AS o 
                             LEFT JOIN customers AS c ON o.customer_number = c.customer_number 
                             LEFT JOIN employees AS e ON o.employee_number = e.employee_number 
                             LEFT JOIN branches AS b ON e.branch_name = b.branch_name";

            if (!string.IsNullOrWhiteSpace(orderNumber))
            {
                query += $" WHERE o.order_number LIKE '%{orderNumber}%'";

                if (startDate.HasValue && endDate.HasValue)
                {
                    query += $" AND o.order_date BETWEEN '{startDate.Value.ToString("yyyy-MM-dd")}' AND '{endDate.Value.ToString("yyyy-MM-dd")}'";
                }
                else if (startDate.HasValue)
                {
                    query += $" AND o.order_date >= '{startDate.Value.ToString("yyyy-MM-dd")}'";
                }
                else if (endDate.HasValue)
                {
                    query += $" AND o.order_date <= '{endDate.Value.ToString("yyyy-MM-dd")}'";
                }
            }
            else
            {
                if (startDate.HasValue && endDate.HasValue)
                {
                    query += $" WHERE o.order_date BETWEEN '{startDate.Value.ToString("yyyy-MM-dd")}' AND '{endDate.Value.ToString("yyyy-MM-dd")}'";
                }
                else if (startDate.HasValue)
                {
                    query += $" WHERE o.order_date >= '{startDate.Value.ToString("yyyy-MM-dd")}'";
                }
                else if (endDate.HasValue)
                {
                    query += $" WHERE o.order_date <= '{endDate.Value.ToString("yyyy-MM-dd")}'";
                }
            }
            query += " ORDER BY o.order_number ASC";

            List<OrderModel> orders = dbContext.GetOrdersFromDb(query);
            return orders;
        }
    }
}
