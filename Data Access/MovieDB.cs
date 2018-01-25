using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Data_Access
{
    public class MovieDB
    {
        public void UpdateMovie(Movie movie)
        {
            using (var ctx = new ContextModel())
            {

                Category cat = ctx.Categories.FirstOrDefault(x => x.ID == movie.Category.ID);
                UserTable user = ctx.UserTables.FirstOrDefault(x => x.ID == movie.User.ID);

                Movie mov = ctx.Movies.FirstOrDefault(x => x.ID == movie.ID);
                mov.Name = movie.Name;
                mov.Description = movie.Description;
                mov.Image = movie.Image;
                mov.Category = cat;
                mov.User = user;
                ctx.SaveChanges();
            }
        }

        public Movie GetMovie(int id)
        {
            Movie mov = null;

            using (var ctx = new ContextModel())
            {
                mov = ctx.Movies.Include("User").FirstOrDefault(x => x.ID == id);
            }
            return mov;
        }

        public void AddMovie(Movie movie)
        {
            using (var ctx = new ContextModel())
            {
                Category cat = ctx.Categories.FirstOrDefault(x => x.ID == movie.Category.ID);
                UserTable user = ctx.UserTables.FirstOrDefault(x => x.ID == movie.User.ID);

                Movie mov = new Movie();
                mov.Name = movie.Name;
                mov.Description = movie.Description;
                mov.Image = movie.Image;
                mov.Category = cat;
                mov.User = user;
                ctx.Movies.Add(mov);
                ctx.SaveChanges();
            }
        }

        public List<Movie> GetAllMoviesByCategory(int categoryId)
        {
            List<Movie> movies = null;

            using (var ctx = new ContextModel())
            {
                movies = ctx.Movies.Where(x => x.Category.ID == categoryId).ToList();
            }
            return movies;
        }

        public List<Movie> GetAllMovies()
        {
            List<Movie> movList = null;

            using (var ctx = new ContextModel())
            {
                movList = ctx.Movies.Include("User").ToList();
            }
            return movList;
        }

        public void DeleteMovie(int? id)
        {
            using (var ctx = new ContextModel())
            {
                Movie mov = ctx.Movies.FirstOrDefault(x => x.ID == id);
                ctx.Movies.Remove(mov);
                ctx.SaveChanges();
            }
        }
    }
}
