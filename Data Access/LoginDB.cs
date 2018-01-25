using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Data_Access
{
    public class LoginDB
    {
        public Login GetLogin(int id)
        {
            Login login = null;

            using (var ctx = new ContextModel())
            {
                login = ctx.Logins.FirstOrDefault(x => x.ID == id);
            }
            return login;
        }

        public List<Login> GetAllLogins()
        {
            List<Login> logins = null;

            using (var ctx = new ContextModel())
            {
                logins = ctx.Logins.ToList();
            }
            return logins;
        }
    }
}
