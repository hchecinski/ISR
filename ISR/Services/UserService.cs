using ISR.Models;
using ISR.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISR.Services
{
    public class UserService
    {
        UserRepository ur;
        public UserService()
        {
            ur = new UserRepository();
        }
        public void AddUser(User userParam)
        {
            ur.AddUser(userParam);
        }

        //Logowanie urzytkownika.
        public User GetUser(User userParam)
        {
            return ur.GetUser(userParam);
        }
    }
}