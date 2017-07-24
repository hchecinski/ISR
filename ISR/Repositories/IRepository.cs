using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISR.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetCollection(string procedurName);
        T GetItem(object itemParam, string procedurName);
        bool AddItem(object itemParam, string procedurName);
        bool UpdateItem(object itemParam, string procedurName);
        bool DeleteItem(object itemParam, string procedurName);
        bool AddCollection(List<T> listParam, string procedurName);
    }
}
