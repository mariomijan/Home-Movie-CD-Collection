using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Business_Logic;

namespace HomeCollection
{
    public class LoginService : ILoginService
    {
        private LoginCtrl lCtrl;

        public LoginService()
        {
            lCtrl = new LoginCtrl();
        }

        public List<Login> GetAllLogins()
        {
            return lCtrl.GetAllLogins();
        }

        public Login GetLogin(int id)
        {
            return lCtrl.GetLogin(id);
        }

        public bool UserExist(string username, string password)
        {
            return lCtrl.UserExist(username, password);
        }
    }
}
