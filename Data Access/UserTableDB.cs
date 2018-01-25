using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Data_Access
{
    public class UserTableDB
    {

        public UserTable GetUserByUsername(string username)
        {
            UserTable user = null;


            using (var ctx = new ContextModel())
            {
                user = ctx.UserTables.Include("Login").Where(l => l.Login.Username == username).FirstOrDefault(x =>
                x.Login.Username == username);

            }
            return user;
        }

        public UserTable GetUser(int id)
        {
            UserTable user = null;

            using (var ctx = new ContextModel())
            {
                user = ctx.UserTables.FirstOrDefault(x => x.ID == id);
            }
            return user;
        }

        public List<UserTable> GetAllUsers()
        {
            List<UserTable> users = null;

            using (var ctx = new ContextModel())
            {
                users = ctx.UserTables.ToList();
            }
            return users;
        }
    }
}
