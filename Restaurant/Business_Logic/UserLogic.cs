
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
            Users = DBAccessConnection.GetUsers();
        }
        private static List<User> Users = new List<User>();
  

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
                    user = new User() { Username = username, Password = password, Name = name, LastName = lastName, Type = type, Availability = 1 };
                    DBAccess.DBAccessConnection.CreateUser(user);
                    Users = DBAccess.DBAccessConnection.GetUsers();
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
                    DBAccess.DBAccessConnection.UpdateUserAvailablity(user, 0);
                    Users = DBAccess.DBAccessConnection.GetUsers();
                    
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
                    DBAccess.DBAccessConnection.UpdateUserAvailablity(user, 1);
                    Users = DBAccess.DBAccessConnection.GetUsers();

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

        public User Login(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
