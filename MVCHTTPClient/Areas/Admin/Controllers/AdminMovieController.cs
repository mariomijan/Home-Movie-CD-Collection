using MVCHTTPClient.Areas.Admin.Security;
using MVCHTTPClient.CategoryReference;
using MVCHTTPClient.Models;
using MVCHTTPClient.MovieReference;
using MVCHTTPClient.UserTableReference;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHTTPClient.Areas.Admin.Controllers
{
    public class AdminMovieController : Controller
    {
        MovieServiceClient movieObj = new MovieServiceClient();
        CategoryServiceClient categoryObj = new CategoryServiceClient();
        UserTableServiceClient userObj = new UserTableServiceClient();
        private static int userId = SessionController.UserId;

        // GET: Admin/Movie
        public ActionResult Index()
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.Movies = movieObj.GetAllMovies();
                return View(cModel);
            }
            return RedirectToAction("Index", "Login");
        }

        public ActionResult Details(int id)
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.User = userObj.GetUser(userId);
                cModel.Movie = movieObj.GetMovie(id);
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
                cModel.Categories = categoryObj.GetAllCategories();
                return View(cModel);
            }
            return RedirectToAction("Index", "Login");

        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase file, CollectionViewModel c, FormCollection collection)
        {
            //Get the selected values ID from the category dropdown list
            int id = Convert.ToInt32(collection["listbox"]);

            if (file != null && file.ContentLength > 0)
                try
                {
                    string path = Path.Combine(Server.MapPath("/Content/Img"),
                                               Path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";
                    c.Movie.Image = "~/Content/Img/" + file.FileName;
                    c.Movie.Category = new MovieReference.Category() { ID = id };
                    c.Movie.User = new MovieReference.UserTable { ID = userId };
                    movieObj.AddMovie(c.Movie);
                    return RedirectToAction("Index");

                }
                catch (Exception ex)
                {
                    //ViewBag.Message = "ERROR:" + ex.Message.ToString();
                    Response.Write("ERROR:" + ex.Message);
                }
            else
            {
                //ViewBag.Message = "You have not specified a file.";
                Response.Write("You have not specified a file.");
            }
            return null;
        }

        public ActionResult Edit(HttpPostedFileBase file, CollectionViewModel cModel, int id)
        {
            if (SessionController.UserIsInSession())
            {
                cModel.User = userObj.GetUser(userId);
                cModel.Categories = categoryObj.GetAllCategories();
                cModel.Movie = movieObj.GetMovie(id);
                return View(cModel);
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult Edit(HttpPostedFileBase file, CollectionViewModel c, FormCollection collection)
        {
            //Get the selected values ID from the category dropdown list

            int id = Convert.ToInt32(collection["listbox"]);

            if (file != null && file.ContentLength > 0)
                try
                {
                    string path = Path.Combine(Server.MapPath("/Content/Img"),
                                               Path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";
                    c.Movie.Image = "~/Content/Img/" + file.FileName;
                    c.Movie.Category = new MovieReference.Category() { ID = id };
                    c.Movie.User = new MovieReference.UserTable { ID = userId };
                    movieObj.UpdateMovie(c.Movie);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                }
            else
            {
                ViewBag.Message = "You have not specified a file.";
            }
            //Or View ???
            return null;
        }

        public ActionResult Delete(int id)
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.User = userObj.GetUser(userId);
                cModel.Movie = movieObj.GetMovie(id);
                return View(cModel);
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            movieObj.DeleteMovie(id);
            return RedirectToAction("Index");

        }
    }
}