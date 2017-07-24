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
        Repository<User> Repo;
        UserRepository ur;

        private const string ADD_USER = "dbo.User_AddUser";
        private const string GET_USER_BY_LOGIN = "dbo.User_GetUserByLogin";

        public UserService()
        {
            Repo = new Repository<User>();
            ur = new UserRepository();
        }
        public void AddUser(User userParam)
        {
            ur.AddUser(userParam);
        }

        //Logowanie urzytkownika.
        public User GetUser(User userParam)
        {
            return Repo.GetItem(new { Login = userParam.Login, Password = userParam.Password }, GET_USER_BY_LOGIN);
            //return ur.GetUser(userParam);
        }
    }
}