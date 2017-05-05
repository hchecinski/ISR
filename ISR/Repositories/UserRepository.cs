using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ISR.Models;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Configuration;

namespace ISR.Repositories
{
    public class UserRepository : IUserRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["dev"].ToString();

        private const string ADD_USER = "dbo.User_AddUser";
        private const string GET_USER_BY_LOGIN = "dbo.User_GetUserByLogin";

        public void AddUser(User userParam)
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Execute(ADD_USER, new { Login = userParam.Login, Password = userParam.Password, Email = userParam.Email}, commandType: CommandType.StoredProcedure);
            }
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUser(User userParam)
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                return db.Query<User>(GET_USER_BY_LOGIN, new { Login = userParam.Login, Password = userParam.Password }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public void UpdateUser(User userParam)
        {
            throw new NotImplementedException();
        }
    }
}