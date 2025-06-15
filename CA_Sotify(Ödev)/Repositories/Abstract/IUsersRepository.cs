using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_Sotify_Ödev_.Models;
namespace CA_Sotify_Ödev_.Repositories.Abstract
{
    internal interface IUsersRepository
    {
        void GetAllUsers();
        void CreateUser(User user);
        void UpdateUser(User updated);
        void DeleteUser(int id);
        
    }
}
