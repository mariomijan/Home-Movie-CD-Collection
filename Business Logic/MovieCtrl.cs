using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Data_Access;

namespace Business_Logic
{
    public class MovieCtrl
    {
        private MovieDB mDb;

        public MovieCtrl()
        {
            mDb = new MovieDB();
        }


        public void AddMovie(Movie movie)
        {
            mDb.AddMovie(movie);

        }

        public void DeleteMovie(int? id)
        {
            mDb.DeleteMovie(id);
        }

        public List<Movie> GetAllMovies()
        {
            return mDb.GetAllMovies();
        }

        public Movie GetMovie(int id)
        {
            return mDb.GetMovie(id);
        }

        public void UpdateMovie(Movie movie)
        {
            mDb.UpdateMovie(movie);
        }

        public List<Movie> GetAllMoviesByCategory(int categoryId)
        {
            return mDb.GetAllMoviesByCategory(categoryId);
        }
    }
}
