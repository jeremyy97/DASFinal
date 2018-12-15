
using DBAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class UserLogic
    {
        public UserLogic()
        {
            Users = DataAccess.GetUsers();
        }
        private static List<User> Users = new List<User>();
        DBAccessConnection DataAccess = new DBAccessConnection();

        public User createUser(string username, string password, string name, string lastName, string type)
        {
            User user;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(type))
            {
                return null;
            }
            else
            {
                if (SearchUserByUsername(username) != null)
                {
                    return null;
                }
                else
                {
                    user = new User() { Username = username, Password = password, Name = name, LastName = lastName, Type = type, Avalability = 1 };
                    Users.Add(user);
                    return user;
                }
            }
        }

        public User SearchUserByUsername(string username)
        {
            User user = null;
            foreach (User i in Users)
            {
                if (i.Username == username)
                {
                    user = i;
                }
            }
            return user;
        }


        public User DisableUser(string username, string loggedUsername)
        {
            User user;
            if (SearchUserByUsername(username).Username == username)
            {
                if (SearchUserByUsername(username).Username == loggedUsername)
                {
                    user = SearchUserByUsername(username);
                    Users.Remove(user);
                    user.Availability = 0;
                    Users.Add(user);
                    return user;
                }
            }
            return null;
        }

        public User EnableUser(string username, string loggedUsername)
        {
            User user;
            if (SearchUserByUsername(username).Username == username)
            {
                if (SearchUserByUsername(username).Username == loggedUsername)
                {
                    user = SearchUserByUsername(username);
                    Users.Remove(user);
                    user.Availability = 1;
                    Users.Add(user);
                    return user;
                }
            }
            return null;
        }

        public List<User> GetUsersList()
        {
            return Users;
        }

        public List<User> GetEnabledUsers()
        {
            List<User> EnabledUsers = new List<User>();
            foreach (var i in Users)
            {
                if (i.Availability == 1)
                {
                    EnabledUsers.Add(i);
                }
            }
            return EnabledUsers;
        }

        public List<User> GetDisabledUsers()
        {
            List<User> DisabledUsers = new List<User>();
            foreach (var i in Users)
            {
                if (i.Availability == 0)
                {
                    DisabledUsers.Add(i);
                }
            }
            return DisabledUsers;
        }

        public Boolean Login(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
