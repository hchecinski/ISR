using ISR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISR.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUser(User userParam);
        void AddUser(User userParam);
        void UpdateUser(User userParam);
    }
}
