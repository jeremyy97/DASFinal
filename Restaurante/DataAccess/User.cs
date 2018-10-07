using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class User
    {
        string Username { set; get; }
        string Password { set; get; }
        string Type { set; get; }
        string Name { set; get; }
        string LastName { set; get; }
        int ID { set; get; }
    }
}
