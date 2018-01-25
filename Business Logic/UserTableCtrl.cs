using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Data_Access;

namespace Business_Logic
{
    public class UserTableCtrl
    {
        private UserTableDB uDb;

        public UserTableCtrl()
        {
            uDb = new UserTableDB();
        }

        public UserTable GetUser(int id)
        {
            return uDb.GetUser(id);
        }

        public UserTable GetUserByUsername(string username)
        {
            return uDb.GetUserByUsername(username);
        }

        public List<UserTable> GetAllUsers()
        {
            return uDb.GetAllUsers();
        }
    }
}
