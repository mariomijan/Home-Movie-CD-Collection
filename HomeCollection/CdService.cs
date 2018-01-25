using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Business_Logic;

namespace HomeCollection
{
    public class CdService : ICdService
    {
        private CdCtrl cCtrl;

        public CdService()
        {
            cCtrl = new CdCtrl();
        }

        public void AddCd(Cd cd)
        {
            cCtrl.AddCd(cd);
        }

        public void DeleteCd(int? id)
        {
            cCtrl.DeleteCd(id);
        }

        public List<Cd> GetAllCds()
        {
            return cCtrl.GetAllCds();
        }

        public List<Cd> GetAllCdsByGenre(int genreId)
        {
            return cCtrl.GetAllCdsByGenre(genreId);
        }

        public Cd GetCd(int id)
        {
            return cCtrl.GetCd(id);
        }

        public void UpdateCd(Cd cd)
        {
            cCtrl.UpdateCd(cd);
        }
    }
}
