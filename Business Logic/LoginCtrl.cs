using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Data_Access;

namespace Business_Logic
{
    public class LoginCtrl
    {
        private LoginDB lDb;

        public LoginCtrl()
        {
            lDb = new LoginDB();
        }

        public List<Login> GetAllLogins()
        {
            return lDb.GetAllLogins();
        }

        public Login GetLogin(int id)
        {
            return lDb.GetLogin(id);
        }

        public bool UserExist(string username, string password)
        {
            if (lDb.GetAllLogins().Any(x => x.Username == username) && 
                lDb.GetAllLogins().Any(x => x.Password == password))
            {
                return true;
            }
            return false;
        }
    }
}
