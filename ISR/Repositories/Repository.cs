using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using ISR.Models;
using System.Data;
using System.Configuration;

namespace ISR.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["dev"].ToString();

        public bool AddCollection(List<T> listParam, string procedurName)
        {
            throw new NotImplementedException();
        }

        public bool AddItem(object itemParam, string procedurName)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(object itemParam, string procedurName)
        {
            throw new NotImplementedException();
        }

        public List<T> GetCollection(string procedurName)
        {
            throw new NotImplementedException();
        }

        public T GetItem(object itemParam, string procedurName)
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                return db.Query<T>(procedurName, itemParam, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public bool UpdateItem(object itemParam, string procedurName)
        {
            throw new NotImplementedException();
        }
    }
}