using MVCHTTPClient.CategoryReference;
using MVCHTTPClient.Models;
using MVCHTTPClient.MovieReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHTTPClient.Controllers
{
    public class MovieController : Controller
    {
        MovieServiceClient movieObj = new MovieServiceClient();
        CategoryServiceClient categoryObj = new CategoryServiceClient();

        //Display all the categories on Index page
        public ActionResult Index()
        {
            var movieCategories = categoryObj.GetAllCategories();
            return View(movieCategories);

        }
        
        //Display movies and category name on Movies page, by selected category
        public ActionResult Movies(int id)
        {
            CollectionViewModel viewModel = new CollectionViewModel();
            viewModel.Movies = movieObj.GetAllMoviesByCategory(id);
            viewModel.Category = categoryObj.GetCategory(id);
            return View(viewModel);

        }
    }
}