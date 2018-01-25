using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HomeCollection
{
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        List<Login> GetAllLogins();
        [OperationContract]
        Login GetLogin(int id);
        [OperationContract]
        bool UserExist(string username, string password);
    }
}
