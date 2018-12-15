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

        public static void UpdateAvailablity(User user, int status)
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
    }
}
