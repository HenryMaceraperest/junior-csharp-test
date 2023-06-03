using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using ui.Properties;
using Dapper;
using ui.Models;

namespace ui.DataAccess
{
    public class DatabaseContext
    {
        private readonly string _ConnectionString = Settings.Default.DbConnectionString;

        public MySqlConnection GetConnection => new MySqlConnection(_ConnectionString);

        public virtual OrderModel GetOrderDetailsFromDb(string query)
        {
            var dbConnection = GetConnection;

            var result = dbConnection.QueryFirstOrDefault<dynamic>(query);

            if (result == null)
            {
                return null;
            }
            var order = new OrderModel
            {
                OrderNumber = (int)result.order_number,
                SalePrice = (decimal)result.sale_price,
                Deposit = (decimal)result.deposit,
                OrderDate = (DateTime)result.order_date,
                Customer = new CustomerModel
                {
                    CustomerNumber = (int)result.customer_number,
                    Forename = (string)result.customer_forename,
                    Surname = (string)result.customer_surname,
                    TelephoneNumber = result.customer_phone.ToString().Replace(".", "")
                },
                Employee = new EmployeeModel
                {
                    EmployeeNumber = (int)result.employee_number,
                    LineManagerNumber = result.line_manager_number,
                    Forename = (string)result.employee_forename,
                    Surname = (string)result.employee_surname,
                    Branch = new BranchModel
                    {
                        BranchName = (string)result.branch_name,
                        Postcode = (string)result.postcode
                    }
                }
            };
            return order;
        }

        public virtual int[] GetOrderNumbersFromDb(string query)
        {
            var dbConnection = GetConnection;

            var results = dbConnection.Query<int>(query);

            return results.ToArray();
        }

        public virtual List<OrderModel> GetOrdersFromDb(string query)
        {
            var dbConnection = GetConnection;
            
            var results = dbConnection.Query<dynamic>(query);
            
            var orderModels = new List<OrderModel>();
            
            foreach (var row in results) 
            {
                var order = new OrderModel
                {
                    OrderNumber = (int)row.order_number,
                    SalePrice = (decimal)row.sale_price,
                    Deposit = (decimal)row.deposit,
                    OrderDate = (DateTime)row.order_date,
                    Customer = new CustomerModel
                    {
                        CustomerNumber = (int)row.customer_number,
                        Forename = (string)row.customer_forename,
                        Surname = (string)row.customer_surname,
                        TelephoneNumber = (string)row.customer_phone.ToString().Replace(".", "")
                    },
                    Employee = new EmployeeModel
                    {
                        EmployeeNumber = (int)row.employee_number,
                        LineManagerNumber = row.line_manager_number,
                        Forename = (string)row.employee_forename,
                        Surname = (string)row.employee_surname,
                        Branch = new BranchModel
                        {
                            BranchName = (string)row.branch_name,
                            Postcode = (string)row.postcode
                        }
                    }
                };

                orderModels.Add(order);
            }

            return orderModels;
        }
    }
}
