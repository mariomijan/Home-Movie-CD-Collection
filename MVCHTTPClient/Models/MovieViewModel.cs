using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCHTTPClient.ServiceMovie;

namespace MVCHTTPClient.Models
{
    public class MovieViewModel
    {
        public List<Movie> Movies { get; set; }
        public Movie Movie { get; set; }

    }
}