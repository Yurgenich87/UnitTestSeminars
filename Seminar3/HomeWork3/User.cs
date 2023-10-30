using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar3.HomeWork3
{
    public class User
    {
        public string Name { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private set; }
        public bool IsAuthenticated { get; private set; }

        public User(string name, string password, bool isAdmin)
        {
            Name = name;
            Password = password;
            IsAdmin = isAdmin;
        }

        // 3.6. Метод аутентификации пользователя
        public bool Authenticate(string name, string password)
        {
            if (name == Name && password == Password)
            {
                IsAuthenticated = true;
                return true;
            }
            else
            {
                IsAuthenticated = false;
                return false;
            }
        }
    }

}
