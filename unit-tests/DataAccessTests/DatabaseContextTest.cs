using Moq;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using ui.DataAccess;
using ui.Models;
using Xunit;

namespace unit_tests.DataAccessTests
{
    public class DatabaseContextTest
    {
        private readonly Mock<DatabaseContext> _dbContextMock;
        private readonly string query;

        public DatabaseContextTest()
        {
            _dbContextMock = new Mock<DatabaseContext>();

            List<OrderModel> expectedOrderList = new List<OrderModel>();

            OrderModel expectedOrder1 = new OrderModel
            {
                OrderNumber = 1,
                SalePrice = (decimal)43920.12,
                Deposit = (decimal)2804.30,
                OrderDate = new DateTime(2017, 12, 13),
                Customer = new CustomerModel
                {
                    CustomerNumber = (int)8123,
                    Forename = "Kathleen",
                    Surname = "Powell",
                    TelephoneNumber = 0.4810909847553.ToString().Replace(".", "")
                },
                Employee = new EmployeeModel
                {
                    EmployeeNumber = 13,
                    LineManagerNumber = null,
                    Forename = "Kimberly",
                    Surname = "Johnson",
                    Branch = new BranchModel
                    {
                        BranchName = "York",
                        Postcode = "YO12 2HJ"
                    }
                }
            };
            
            expectedOrderList.Add(expectedOrder1);

            OrderModel expectedOrder2 = new OrderModel
            {
                OrderNumber = 2,
                SalePrice = (decimal)45520.12,
                Deposit = (decimal)2334.30,
                OrderDate = new DateTime(2020, 11, 11),
                Customer = new CustomerModel
                {
                    CustomerNumber = (int)8124,
                    Forename = "Corey",
                    Surname = "Pascal",
                    TelephoneNumber = 0.4813569847553.ToString().Replace(".", "")
                },
                Employee = new EmployeeModel
                {
                    EmployeeNumber = 13,
                    LineManagerNumber = null,
                    Forename = "Kimberly",
                    Surname = "Johnson",
                    Branch = new BranchModel
                    {
                        BranchName = "York",
                        Postcode = "YO12 2HJ"
                    }
                }
            };
            expectedOrderList.Add(expectedOrder2);

            _dbContextMock.Setup(db => db.GetOrdersFromDb(It.IsAny<string>())).Returns(expectedOrderList);


            OrderModel expectedOrder = new OrderModel
            {
                OrderNumber = 1,
                SalePrice = (decimal)43920.12,
                Deposit = (decimal)2804.30,
                OrderDate = new DateTime(2017, 12, 13),
                Customer = new CustomerModel
                {
                    CustomerNumber = (int)8123,
                    Forename = "Kathleen",
                    Surname = "Powell",
                    TelephoneNumber = 0.4810909847553.ToString().Replace(".", "")
                },
                Employee = new EmployeeModel
                {
                    EmployeeNumber = 13,
                    LineManagerNumber = null,
                    Forename = "Kimberly",
                    Surname = "Johnson",
                    Branch = new BranchModel
                    {
                        BranchName = "York",
                        Postcode = "YO12 2HJ"
                    }
                }
            };

            _dbContextMock.Setup(db => db.GetOrderDetailsFromDb(It.IsAny<string>())).Returns(expectedOrder);

            query = "Any query will do";
        }

        [Fact]
        public void GetOrderDetailsFromDb_ShouldReturnOrderDetails()
        {
            int id = 1;
            string query = @"SELECT o.order_number, o.customer_number, o.sale_price, o.deposit, o.order_date, 
                             c.customer_number, c.forename as customer_forename, c.surname as customer_surname, c.telephone_number as customer_phone, 
                             e.employee_number, e.branch_name, e.line_manager_number, e.forename as employee_forename, e.surname as employee_surname, 
                             b.branch_name, b.postcode 
                             FROM orders AS o 
                             LEFT JOIN customers AS c ON o.customer_number = c.customer_number 
                             LEFT JOIN employees AS e ON o.employee_number = e.employee_number 
                             LEFT JOIN branches AS b ON e.branch_name = b.branch_name WHERE o.order_number = '" + id + "'";


            OrderModel result = new OrderModel();
            if (!IsValidQuery(query, id))
            {
                result = null;
            }
            else
            {
                result = _dbContextMock.Object.GetOrderDetailsFromDb(query);
            }


            Assert.NotNull(result);
            Assert.Equal(id, result.OrderNumber);
            Assert.IsType<OrderModel>(result);
        }

        [Fact]
        public void GetOrderDetailsFromDb_ShouldReturnNull()
        {
            int id = 99999;
            string query = @"SELECT o.order_number, o.customer_number, o.sale_price, o.deposit, o.order_date, 
                             c.customer_number, c.forename as customer_forename, c.surname as customer_surname, c.telephone_number as customer_phone, 
                             e.employee_number, e.branch_name, e.line_manager_number, e.forename as employee_forename, e.surname as employee_surname, 
                             b.branch_name, b.postcode 
                             FROM orders AS o 
                             LEFT JOIN customers AS c ON o.customer_number = c.customer_number 
                             LEFT JOIN employees AS e ON o.employee_number = e.employee_number 
                             LEFT JOIN branches AS b ON e.branch_name = b.branch_name WHERE o.order_number = '" + id + "'";


            OrderModel result = new OrderModel();
            if (!IsValidQuery(query, id))
            {
                result = null;
            }
            else
            {
                result = _dbContextMock.Object.GetOrderDetailsFromDb(query);
            }

            Assert.Null(result);
        }

        [Fact]
        public void GetOrderNumbersFromDb_ShouldReturnIntArray()
        {
            int orderNumber = 1;
            DateTime startDate = new DateTime(2017, 10, 12);
            DateTime endDate = new DateTime(2017, 11, 01);
            string query = @"SELECT order_number FROM orders";
                   query += $" WHERE order_number LIKE '%{orderNumber}%'";
                   query += $" AND order_date BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}'";
                   query += " ORDER BY order_number ASC";

            int[] result;

            if (!IsValidQuery(query, orderNumber, startDate, endDate))
            {
                result = null;
            }
            else
            {
                result = _dbContextMock.Object.GetOrderNumbersFromDb(query);
            }

            Assert.NotNull(result);
            Assert.IsType<int[]>(result);
        }

        [Fact]
        public void GetOrderNumbersFromDb_ShouldReturnNull()
        {
            int orderNumber = 1;
            DateTime startDate = new DateTime(2017, 11, 01);
            DateTime endDate = new DateTime(2017, 10, 12);
            string query = @"SELECT order_number FROM orders";
                   query += $" WHERE order_number LIKE '%{orderNumber}%'";
                   query += $" AND order_date BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}'";
                   query += " ORDER BY order_number ASC";

            int[] result;

            if (!IsValidQuery(query, orderNumber, startDate, endDate))
            {
                result = null;
            }
            else
            {
                result = _dbContextMock.Object.GetOrderNumbersFromDb(query);
            }

            Assert.Null(result);
        }

        [Fact]
        public void GetOrdersFromDb_ShouldReturnListOfOrderModels()
        {
            int orderNumber = 1;
            DateTime startDate = new DateTime(2017, 10, 12);
            DateTime endDate = new DateTime(2017, 11, 01);
            string query = @"SELECT o.order_number, o.customer_number, o.sale_price, o.deposit, o.order_date, 
                             c.forename as customer_forename, c.surname as customer_surname, c.telephone_number as customer_phone, 
                             e.employee_number, e.line_manager_number, e.forename as employee_forename, e.surname as employee_surname, 
                             b.branch_name, b.postcode 
                             FROM orders AS o 
                             LEFT JOIN customers AS c ON o.customer_number = c.customer_number 
                             LEFT JOIN employees AS e ON o.employee_number = e.employee_number 
                             LEFT JOIN branches AS b ON e.branch_name = b.branch_name";           
                    query += $" WHERE o.order_number LIKE '%{orderNumber}%'";
                    query += $" AND o.order_date BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}'";
                    query += " ORDER BY o.order_number ASC";


            List<OrderModel> orders = new List<OrderModel>();

            if (!IsValidQuery(query, orderNumber, startDate, endDate))
            {
                orders = null;
            }
            else
            {
                orders = _dbContextMock.Object.GetOrdersFromDb(query);
            }


            Assert.NotNull(orders);
            Assert.IsType<List<OrderModel>>(orders);
        }

        [Fact]
        public void GetOrdersFromDb_ShouldReturnNull()
        {
            int orderNumber = 1;
            DateTime startDate = new DateTime(2017, 11, 01);
            DateTime endDate = new DateTime(2017, 10, 12);

            string query = @"SELECT o.order_number, o.customer_number, o.sale_price, o.deposit, o.order_date, 
                             c.forename as customer_forename, c.surname as customer_surname, c.telephone_number as customer_phone, 
                             e.employee_number, e.line_manager_number, e.forename as employee_forename, e.surname as employee_surname, 
                             b.branch_name, b.postcode 
                             FROM orders AS o 
                             LEFT JOIN customers AS c ON o.customer_number = c.customer_number 
                             LEFT JOIN employees AS e ON o.employee_number = e.employee_number 
                             LEFT JOIN branches AS b ON e.branch_name = b.branch_name";
            query += $" WHERE o.order_number LIKE '%{orderNumber}%'";
            query += $" AND o.order_date BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}'";
            query += " ORDER BY o.order_number ASC";

            List<OrderModel> orders = new List<OrderModel>();

            if (!IsValidQuery(query, orderNumber, startDate, endDate))
            {
                orders =  null;
            }
            else
            {
                orders = _dbContextMock.Object.GetOrdersFromDb(query);
            }

            Assert.Null(orders);
        }

        private bool IsValidQuery(string query, int orderNumber, DateTime? startDate = null, DateTime? endDate = null)
        {
            if (!int.TryParse(orderNumber.ToString(), out _) || orderNumber > 30000)
            {
                return false;
            }
            if ((startDate != null && endDate != null) && startDate > endDate)
            {
                return false;
            }
            return true;
        }
    }
}
