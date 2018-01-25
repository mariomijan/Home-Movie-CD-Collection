using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Data_Access;

namespace Business_Logic
{
    public class CdCtrl
    {
        private CdDB cDb;

        public CdCtrl()
        {
            cDb = new CdDB();
        }

        public void AddCd(Cd cd)
        {
            cDb.AddCd(cd);
        }

        public void DeleteCd(int? id)
        {
            cDb.DeleteCd(id);
        }

        public List<Cd> GetAllCds()
        {
            return cDb.GetAllCds();
        }

        public Cd GetCd(int id)
        {
            return cDb.GetCd(id);
        }

        public void UpdateCd(Cd cd)
        {
            cDb.UpdateCd(cd);
        }

        public List<Cd> GetAllCdsByGenre(int genreId)
        {
            return cDb.GetAllCdsByGenre(genreId);
        }
    }
}
