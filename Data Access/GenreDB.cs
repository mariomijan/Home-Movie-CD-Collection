using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class GenreDB
    {
        public void AddGenre(Genre genre)
        {
            using (var ctx = new ContextModel())
            {
                UserTable user = ctx.UserTables.FirstOrDefault(x => x.ID == genre.User.ID);

                Genre g = new Genre();
                g.Name = genre.Name;
                g.User = user;
                ctx.Genres.Add(g);
                ctx.SaveChanges();
            }
        }

        public void DeleteGenre(int? id)
        {
            using (var ctx = new ContextModel())
            {
                Genre gen = ctx.Genres.FirstOrDefault(x => x.ID == id);
                ctx.Genres.Remove(gen);
                ctx.SaveChanges();
            }
        }

        public Genre GetGenre(int id)
        {
            Genre gen = null;

            using (var ctx = new ContextModel())
            {
                gen = ctx.Genres.FirstOrDefault(x => x.ID == id);
            }
            return gen;
        }

        public void UpdateGenre(Genre genre)
        {
            using (var ctx = new ContextModel())
            {
                Genre gen = ctx.Genres.FirstOrDefault(x => x.ID == genre.ID);
                UserTable user = ctx.UserTables.FirstOrDefault(x => x.ID == genre.User.ID);

                gen.Name = genre.Name;
                gen.User = user;
                ctx.SaveChanges();
            }
        }

        public List<Genre> GetAllGenres()
        {
            List<Genre> genList = null;

            using (var ctx = new ContextModel())
            {
                genList = ctx.Genres.Include("User").ToList();
            }
            return genList;
        }
    }
}
