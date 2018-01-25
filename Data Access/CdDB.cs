using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Data_Access
{
    public class CdDB
    {
        public void AddCd(Cd cd)
        {
            using (var ctx = new ContextModel())
            {
                Genre gen = ctx.Genres.FirstOrDefault(x => x.ID == cd.Genre.ID);
                UserTable user = ctx.UserTables.FirstOrDefault(x => x.ID == cd.User.ID);

                Cd c = new Cd();
                c.Name = cd.Name;
                c.Description = cd.Description;
                c.Image = cd.Image;
                c.Genre = gen;
                c.User = user;
                ctx.Cds.Add(c);
                ctx.SaveChanges();
            }
        }

        public void DeleteCd(int? id)
        {
            using (var ctx = new ContextModel())
            {
                Cd c = ctx.Cds.FirstOrDefault(x => x.ID == id);
                ctx.Cds.Remove(c);
                ctx.SaveChanges();
            }
        }

        public List<Cd> GetAllCds()
        {
            List<Cd> cds = null;

            using (var ctx = new ContextModel())
            {
                cds = ctx.Cds.Include("User").ToList();
            }
            return cds;
        }

        public List<Cd> GetAllCdsByGenre(int genreId)
        {
            List<Cd> cds = null;

            using (var ctx = new ContextModel())
            {
                cds = ctx.Cds.Where(x => x.Genre.ID == genreId).ToList();
            }
            return cds;
        }

        public Cd GetCd(int id)
        {
            Cd cd = null;

            using (var ctx = new ContextModel())
            {
                cd = ctx.Cds.Include("User").FirstOrDefault(x => x.ID == id);
            }
            return cd;
        }

        public void UpdateCd(Cd cd)
        {
            using (var ctx = new ContextModel())
            {
                Genre gen = ctx.Genres.FirstOrDefault(x => x.ID == cd.Genre.ID);
                UserTable user = ctx.UserTables.FirstOrDefault(x => x.ID == cd.User.ID);

                Cd c = ctx.Cds.FirstOrDefault(x => x.ID == cd.ID);
                c.Name = cd.Name;
                c.Description = cd.Description;
                c.Image = cd.Image;
                c.Genre = gen;
                c.User = user;
                ctx.SaveChanges();
            }
        }
    }
}
