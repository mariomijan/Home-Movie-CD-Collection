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
    public interface IGenreService
    {
        [OperationContract]
        void AddGenre(Genre genre);

        [OperationContract]
        void UpdateGenre(Genre genre);

        [OperationContract]
        void DeleteGenre(int? id);

        [OperationContract]
        List<Genre> GetAllGenres();

        [OperationContract]
        Genre GetGenre(int id);
    }
}
