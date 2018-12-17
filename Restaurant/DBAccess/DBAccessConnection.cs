using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    public static class DBAccessConnection
    {

        static string connString = "Data Source=LAPTOP-BCKLRFPR\\MSSQLSERVER01;Initial Catalog=restaurantDB;Integrated Security=True;";

        public static List<User> GetUsers()
        {
            List<User> users;
            using (SqlConnection conn = new SqlConnection(connString))  
            {
                users = conn.Query<User>("select * from [restaurantDB].[dbo].[USER]").ToList();
            }
            return users;
        }

        public static void CreateUser(User user)
        {
            string sql = "insert into [restaurantDB].[dbo].[USER] ([username], [password], [name] , [lastname] , [type] , [availability]) VALUES (@username, @password, @name,@lastname,@type,@availability)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new {
                    user.Username,
                    user.Password,
                    user.Name,
                    user.LastName,
                    user.Type,
                    user.Availability
                });
            }
        }

        public static void DeleteUser(User user)
        {
            string sql = "delete from [restaurantDB].[dbo].[USER] where username = @username";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    username = user.Username
                });
            }
        }

        public static void UpdateUserAvailablity(User user, int status)
        {
            string sql = "update [restaurantDB].[dbo].[USER] set availability = @availability where username = @username";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    username = user.Username,
                    availability = status
                });
            }
        }

        public static List<Product> GetProducts()
        {
            List<Product> products;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                products = conn.Query<Product>("select * from [restaurantDB].[dbo].[PRODUCT]").ToList();
            }
            return products;
        } 

        public static void CreateProduct(Product product)
        {
            string sql = "insert into [restaurantDB].[dbo].[PRODUCT] ([id], [name], [description] , [cost]) VALUES (@id, @name, @description,@cost)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    product.ID,
                    product.Name,
                    product.Description,
                    product.Cost
                });
            }
        }

        public static void DeleteProduct(Product product)
        {
            string sql = "delete from [restaurantDB].[dbo].[PRODUCT] where id = @id";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    id = product.ID
                });
            }
        }

        public static List<Table> GetTables()
        {
            List<Table> tables;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                tables = conn.Query<Table>("select * from [restaurantDB].[dbo].[TABLE]").ToList();
            }
            return tables;
        }

        public static void CreateTable(Table table)
        {
            string sql = "insert into [restaurantDB].[dbo].[TABLE] ([id], [people], [available]) VALUES (@id, @people, @available)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    table.ID,
                    table.People,
                    table.Available
                });
            }
        }

        public static void DeleteTable(Table table)
        {
            string sql = "delete from [restaurantDB].[dbo].[TABLE] where id = @id";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    id = table.ID
                });
            }
        }

        public static void UpdateTableAvailability(Table table, int status)
        {
            string sql = "update [restaurantDB].[dbo].[TABLE] set available = @available where id = @id";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    id = table.ID,
                    available = status
                });
            }
        }

        public static List<Order_Product> GetOrders()
        {
            List<Order_Product> orders;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                orders = conn.Query<Order_Product>("select id, table_id, product_id, cost, paid, completed from [restaurantDB].[dbo].[ORDER]").ToList();
            }
            return orders;
        }

        public static void CreateOrder(Order_Product order)
        {
            string sql = "insert into [restaurantDB].[dbo].[ORDER] ([table_id], [product_id], [cost], [paid], [completed]) VALUES (@table_id, @product_id, @cost, @paid, @completed)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    table_id = order.Table_id,
                    product_id = order.Product_id,
                    cost = order.Cost,
                    paid = order.Paid,
                    completed = order.Completed
                });
            }
        }

        public static void PayOrder(int orden)
        {
            string sql = "update [restaurantDB].[dbo].[ORDER] set paid = @paid where id = @id";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    id = orden,
                    paid = 1
                });
            }
        }

        public static List<Bill> GetBills()
        {
            List<Bill> bills;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                bills = conn.Query<Bill>("select * from [restaurantDB].[dbo].[BILL]").ToList();
            }
            return bills;
        }

        public static void CreateBill(Bill bill)
        {
            string sql = "insert into [restaurantDB].[dbo].[BILL] ([id], [name], [orders] , [tax] , [cost] , [final_cost]) VALUES (@id, @name, @orders,@tax,@cost,@final_cost)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    bill.ID,
                    bill.Name,
                    bill.Orders,
                    bill.Tax,
                    bill.Cost,
                    final_cost = bill.FinalCost
                });
            }
        }


    }
}
