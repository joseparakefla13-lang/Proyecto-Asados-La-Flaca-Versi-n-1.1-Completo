using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool Login(string inputUsername, string inputPassword)
        {
            return Username == inputUsername && Password == inputPassword;
        }
    }
}