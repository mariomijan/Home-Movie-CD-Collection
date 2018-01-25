using Core;
using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class GenreCtrl
    {
        private GenreDB gDb;

        public GenreCtrl()
        {
            gDb = new GenreDB();
        }

        public void AddGenre(Genre genre)
        {
            gDb.AddGenre(genre);
        }

        public void DeleteGenre(int? id)
        {
            gDb.DeleteGenre(id);
        }

        public List<Genre> GetAllGenres()
        {
            return gDb.GetAllGenres();
        }

        public Genre GetGenre(int id)
        {
            return gDb.GetGenre(id);
        }

        public void UpdateGenre(Genre genre)
        {
            gDb.UpdateGenre(genre);
        }
    }
}
