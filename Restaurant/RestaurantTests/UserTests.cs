using System;
using BusinessLogic;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RestaurantTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void AUserIsCreated()
        {
            //Arrange
            UserLogic logic = new UserLogic();
            User lastUser;

            //Act
            User user = logic.CreateUser("user1", "123", "Usuario", "Uno", "waiter");
            lastUser = logic.SearchUserByUsername("user1");

            //Assert
            Assert.IsNotNull(lastUser);
        }

        [TestMethod]
        public void AUsernameCannotBeUsedForTwoOrMoreUsers()
        {
            //Arrange
            UserLogic logic = new UserLogic();
            User firstUser;
            User secondUser;

            //Act
            
            firstUser = logic.CreateUser("user1", "123", "Mesero", "Uno", "waiter");
            secondUser = logic.CreateUser("user1", "456", "Mesero", "Dos", "waiter");

            //Assert
            Assert.IsNotNull(firstUser,"UNO");
            Assert.IsNull(secondUser);
        }
    }
}
