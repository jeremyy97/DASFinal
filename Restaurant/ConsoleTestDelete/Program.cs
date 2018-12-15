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
            DBAccessConnection test = new DBAccessConnection();

            List<User> users = test.GetUsers();

            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();




        }
    }
}
