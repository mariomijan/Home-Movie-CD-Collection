using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Business_Logic;

namespace HomeCollection
{
    public class UserTableService : IUserTableService
    {
        private UserTableCtrl uCtrl;

        public UserTableService()
        {
            uCtrl = new UserTableCtrl();
        }

        public List<UserTable> GetAllUsers()
        {
            return uCtrl.GetAllUsers();
        }

        public UserTable GetUser(int id)
        {
            return uCtrl.GetUser(id);
        }

        public UserTable GetUserByUsername(string username)
        {
            return uCtrl.GetUserByUsername(username);
        }
    }
}
