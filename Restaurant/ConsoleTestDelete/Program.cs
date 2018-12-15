using DBAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User user = new User() { Username = "Eddie", Password = "123", Name = "Eddie", LastName = "Carranza", Type = "Mesero", Availability = 1 };
            DBAccessConnection.CreateUser(user);
            List<User> users = DBAccessConnection.GetUsers();
            //DBAccessConnection.DeleteUser(user);
            DBAccessConnection.UpdateAvailablity(user,0);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();




        }
    }
}
