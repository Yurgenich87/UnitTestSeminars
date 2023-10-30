using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar3.HomeWork3
{
    
    public class UserRepository
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public bool FindByName(string username)
        {
            return users.Any(user => user.Name == username);
        }

        public void LogoutNonAdminUsers()
        {
            users.RemoveAll(user => !user.IsAdmin);
        }
    }

    
}
