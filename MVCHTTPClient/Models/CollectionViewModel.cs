using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCHTTPClient.Models
{
    //To use two models in one view
    public class CollectionViewModel
    {
        public List<MovieReference.Movie> Movies { get; set; }
        public MovieReference.Movie Movie { get; set; }
        public CategoryReference.Category Category { get; set; }
        public List<CategoryReference.Category> Categories { get; set; }
        public List<CdReference.Cd> Cds { get; set; }
        public CdReference.Cd Cd { get; set; }
        public GenreReference.Genre Genre { get; set; }
        public List<GenreReference.Genre> Genres { get; set; }
        public List<LoginReference.Login> logins { get; set; }
        public UserTableReference.UserTable User { get; set; }
        public List<UserTableReference.UserTable> users { get; set; }
    }
}