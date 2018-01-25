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
    public interface IMovieService
    {
        [OperationContract]
        void AddMovie(Movie movie);

        [OperationContract]
        void UpdateMovie(Movie movie);

        [OperationContract]
        Movie GetMovie(int id);

        [OperationContract]
        List<Movie> GetAllMovies();

        [OperationContract]
        void DeleteMovie(int? id);

        [OperationContract]
        List<Movie> GetAllMoviesByCategory(int categoryId);

    }
}
