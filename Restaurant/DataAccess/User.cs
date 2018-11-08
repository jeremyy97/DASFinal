using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class User
    {
        public string Username { set; get; }
        public string Password { set; get;  }
        public string Name { set; get; }
        public string LastName { set; get; }
        public int ID { set; get; }
        public string Type { set; get; }

        public User(string username, string password, string name, string lastName, int id, string type)
        {
            Username = username;
            Password = password;
            Name = name;
            LastName = lastName;
            ID = id;
            Type = type;
        }
    }
}
    