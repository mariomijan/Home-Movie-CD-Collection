using MVCHTTPClient.Areas.Admin.Security;
using MVCHTTPClient.CdReference;
using MVCHTTPClient.GenreReference;
using MVCHTTPClient.Models;
using MVCHTTPClient.UserTableReference;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHTTPClient.Areas.Admin.Controllers
{
    public class AdminCdController : System.Web.Mvc.Controller
    {
        CdServiceClient cdObj = new CdServiceClient();
        GenreServiceClient genreObj = new GenreServiceClient();
        UserTableServiceClient userObj = new UserTableServiceClient();
        private int userId = SessionController.UserId;

        // GET: Admin/AdminCd
        public ActionResult Index()
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.Cds = cdObj.GetAllCds();
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
                cModel.Cd = cdObj.GetCd(id);
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
                cModel.Genres = genreObj.GetAllGenres();
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
                    c.Cd.Image = "~/Content/Img/" + file.FileName;
                    c.Cd.Genre = new CdReference.Genre() { ID = id };
                    c.Cd.User = new CdReference.UserTable { ID = userId };
                    cdObj.AddCd(c.Cd);
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
            return null;
        }

        public ActionResult Edit(FormCollection col, int id)
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.User = userObj.GetUser(userId);
                cModel.Genres = genreObj.GetAllGenres();
                cModel.Cd = cdObj.GetCd(id);
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
                    c.Cd.Image = "~/Content/Img/" + file.FileName;
                    c.Cd.Genre = new CdReference.Genre() { ID = id };
                    c.Cd.User = new CdReference.UserTable() { ID = userId };
                    cdObj.UpdateCd(c.Cd);
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
            return null;
        }

        public ActionResult Delete(int id)
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.User = userObj.GetUser(userId);
                cModel.Cd = cdObj.GetCd(id);
                return View(cModel);
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            cdObj.DeleteCd(id);
            return RedirectToAction("Index");
        }
    }
}
