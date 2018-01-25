using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Business_Logic;

namespace HomeCollection
{
    public class GenreService : IGenreService
    {
        private GenreCtrl gCrl;

        public GenreService()
        {
            gCrl = new GenreCtrl();   
        }

        public void AddGenre(Genre genre)
        {
            gCrl.AddGenre(genre);   
        }

        public void DeleteGenre(int? id)
        {
            gCrl.DeleteGenre(id);
        }

        public List<Genre> GetAllGenres()
        {
            return gCrl.GetAllGenres();
        }

        public Genre GetGenre(int id)
        {
            return gCrl.GetGenre(id);
        }

        public void UpdateGenre(Genre genre)
        {
            gCrl.UpdateGenre(genre);
        }
    }
}
