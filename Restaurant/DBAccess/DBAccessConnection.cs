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
    public class DBAccessConnection
    {

        static string connString = "Data Source=LAPTOP-BCKLRFPR\\MSSQLSERVER01;Initial Catalog=restaurantDB;Integrated Security=True;";
        public List<User> GetUsers()
        {
            List<User> users;
            using (SqlConnection conn = new SqlConnection(connString))  
            {
                users = conn.Query<User>("select * from [restaurantDB].[dbo].[USER]").ToList();
            }
            return users;
        }
    }
}
