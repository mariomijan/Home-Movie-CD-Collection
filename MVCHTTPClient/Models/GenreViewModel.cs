using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCHTTPClient.ServiceGenre;

namespace MVCHTTPClient.Models
{
    public class GenreViewModel
    {
        public Genre Genre { get; set; }
        public List<Genre> Genres { get; set; }

    }
}