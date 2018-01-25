using MVCHTTPClient.Areas.Admin.Security;
using MVCHTTPClient.CategoryReference;
using MVCHTTPClient.CdReference;
using MVCHTTPClient.GenreReference;
using MVCHTTPClient.LoginReference;
using MVCHTTPClient.Models;
using MVCHTTPClient.MovieReference;
using MVCHTTPClient.UserTableReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHTTPClient.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        CategoryServiceClient categoryObj = new CategoryServiceClient();
        MovieServiceClient movieObj = new MovieServiceClient();
        GenreServiceClient genreObj = new GenreServiceClient();
        CdServiceClient cdObj = new CdServiceClient();
        UserTableServiceClient userObj = new UserTableServiceClient();
        LoginServiceClient loginObj = new LoginServiceClient();

        public ActionResult Index()
        {
            int userId = SessionController.UserId;

            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.Categories = categoryObj.GetAllCategories();
                cModel.Movies = movieObj.GetAllMovies();
                cModel.Genres = genreObj.GetAllGenres();
                cModel.Cds = cdObj.GetAllCds();
                cModel.User = userObj.GetUser(userId);
                cModel.users = userObj.GetAllUsers();
                return View(cModel);

            }
            return RedirectToAction("Index", "Login");
        }

        public ActionResult LogOff()
        {
            SessionController.CloseSession();
            return RedirectToAction("Index", "Login");
        }
    }
}