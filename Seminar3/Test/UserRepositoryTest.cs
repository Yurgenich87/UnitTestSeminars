using System;
using NUnit.Framework;
using UnitTest.Seminar3.HomeWork3;

namespace UnitTest.Seminar3.Test
{
    

    [TestFixture]
    public class UserRepositoryTest
    {
        [Test]
        public void LogoutNonAdminUsers_RemovesNonAdminUsers()
        {
            // Arrange
            var userRepository = new UserRepository();
            var adminUser = new User("admin","123", true);
            var nonAdminUser1 = new User("user1","111", false);
            var nonAdminUser2 = new User("user2","222", false);
            userRepository.AddUser(adminUser);
            userRepository.AddUser(nonAdminUser1);
            userRepository.AddUser(nonAdminUser2);

            // Act
            userRepository.LogoutNonAdminUsers();

            // Assert
            Assert.That(userRepository.FindByName("admin"), Is.True);
            Assert.That(userRepository.FindByName("user1"), Is.False);
            Assert.That(userRepository.FindByName("user2"), Is.False);
        }
    }

}
