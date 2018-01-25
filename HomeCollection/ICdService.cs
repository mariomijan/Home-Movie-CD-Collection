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
    public interface ICdService
    {
        [OperationContract]
        void AddCd(Cd cd);

        [OperationContract]
        void UpdateCd(Cd cd);

        [OperationContract]
        Cd GetCd(int id);

        [OperationContract]
        List<Cd> GetAllCds();

        [OperationContract]
        void DeleteCd(int? id);

        [OperationContract]
        List<Cd> GetAllCdsByGenre(int genreId);

    }
}
