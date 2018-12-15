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
        static string connString = "Data Source=LAPTOP-BCKLLFPR;Initial Catalog=restaurantDB;Integrated Security=True;";

        public List<User> GetUsers()
        {
            List<User> users;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                users = conn.Query<User>("Select * FROM USER").ToList();
            }
            return users;
        }
    }
}
