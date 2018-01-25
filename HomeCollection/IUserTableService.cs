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
    public interface IUserTableService
    {
        [OperationContract]
        UserTable GetUser(int id);

        [OperationContract]
        UserTable GetUserByUsername(string username);

        [OperationContract]
        List<UserTable> GetAllUsers();

    }
}
