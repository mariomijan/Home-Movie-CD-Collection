using Business_Logic;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCollection
{
    public class MovieService : IMovieService
    {
        private MovieCtrl mCtrl;

        public MovieService()
        {
            mCtrl = new MovieCtrl();
        }

        public void AddMovie(Movie movie)
        {
            mCtrl.AddMovie(movie);
        }

        public void DeleteMovie(int? id)
        {
            mCtrl.DeleteMovie(id);
        }

        public List<Movie> GetAllMovies()
        {
            return mCtrl.GetAllMovies();
        }

        public List<Movie> GetAllMoviesByCategory(int categoryId)
        {
            return mCtrl.GetAllMoviesByCategory(categoryId);
        }

        public Movie GetMovie(int id)
        {
            return mCtrl.GetMovie(id);
        }

        public void UpdateMovie(Movie movie)
        {
            mCtrl.UpdateMovie(movie);
        }
    }
}
