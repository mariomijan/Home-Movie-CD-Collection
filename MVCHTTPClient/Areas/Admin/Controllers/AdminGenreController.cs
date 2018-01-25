using MVCHTTPClient.Areas.Admin.Security;
using MVCHTTPClient.GenreReference;
using MVCHTTPClient.Models;
using MVCHTTPClient.UserTableReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHTTPClient.Areas.Admin.Controllers
{
    public class AdminGenreController : System.Web.Mvc.Controller
    {
        GenreServiceClient genreObj = new GenreServiceClient();
        UserTableServiceClient userObj = new UserTableServiceClient();
        private int userId = SessionController.UserId;

        // GET: Admin/Genre
        public ActionResult Index()
        {

            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.Genres = genreObj.GetAllGenres();
                return View(cModel);
            }

            return RedirectToAction("Index", "Login");
           
        }

        //Admin
        public ActionResult Details(int id)
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.User = userObj.GetUser(userId);
                cModel.Genre = genreObj.GetGenre(id);
                return View(cModel);
            }
            return RedirectToAction("Index", "Login");
        }

        public ActionResult Create()
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.User = userObj.GetUser(userId);
                return View(cModel);

            }
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult Create(CollectionViewModel c)
        {
            c.Genre.User = new GenreReference.UserTable() { ID = userId };
            genreObj.AddGenre(c.Genre);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.User = userObj.GetUser(userId);
                cModel.Genre = genreObj.GetGenre(id);
                return View(cModel);
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult Edit(CollectionViewModel c)
        {
            c.Genre.User = new GenreReference.UserTable() { ID = userId };
            genreObj.UpdateGenre(c.Genre);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(CollectionViewModel cModel, int id)
        {
            if (SessionController.UserIsInSession())
            {
                cModel.User = userObj.GetUser(userId);
                cModel.Genre = genreObj.GetGenre(id);
                return View(cModel);
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            genreObj.DeleteGenre(id);
            return RedirectToAction("Index");
        }
    }
}