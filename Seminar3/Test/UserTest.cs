using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTest.Seminar3.HomeWork3;


namespace UnitTest.Seminar3.Test
{
    
    [TestFixture]
    public class UserTest
    {
        [Test]
        public void Authenticate_WithCorrectCredentials_ShouldReturnTrue()
        {
            // Arrange
            string username = "testuser";
            string password = "password";
            User user = new User(username, password, false);

            // Act
            bool isAuthenticated = user.Authenticate(username, password);

            // Assert
            Assert.IsTrue(isAuthenticated);
        }

        [Test]
        public void Authenticate_WithIncorrectPassword_ShouldReturnFalse()
        {
            // Arrange
            string username = "testuser";
            string correctPassword = "password";
            string incorrectPassword = "wrongpassword";
            User user = new User(username, correctPassword, false);

            // Act
            bool isAuthenticated = user.Authenticate(username, incorrectPassword);

            // Assert
            Assert.IsFalse(isAuthenticated);
        }

        [Test]
        public void Authenticate_WithIncorrectUsername_ShouldReturnFalse()
        {
            // Arrange
            string correctUsername = "testuser";
            string incorrectUsername = "wronguser";
            string password = "password";
            User user = new User(correctUsername, password, false);

            // Act
            bool isAuthenticated = user.Authenticate(incorrectUsername, password);

            // Assert
            Assert.IsFalse(isAuthenticated);
        }
    }

}
