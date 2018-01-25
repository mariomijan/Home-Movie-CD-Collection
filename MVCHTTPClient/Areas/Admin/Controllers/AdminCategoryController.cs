using MVCHTTPClient.Areas.Admin.Security;
using MVCHTTPClient.CategoryReference;
using MVCHTTPClient.Models;
using MVCHTTPClient.UserTableReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHTTPClient.Areas.Admin.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryServiceClient categoryObj = new CategoryServiceClient();
        UserTableServiceClient userObj = new UserTableServiceClient();

        private int userId = SessionController.UserId;

        public ActionResult Index()
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.Categories = categoryObj.GetAllCategories();
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
                cModel.Category = categoryObj.GetCategory(id);
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
            c.Category.User = new CategoryReference.UserTable() { ID = userId };
            categoryObj.AddCategory(c.Category);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.User = userObj.GetUser(userId);
                cModel.Category = categoryObj.GetCategory(id);
                return View(cModel);
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult Edit(CollectionViewModel c)
        {
            c.Category.User = new CategoryReference.UserTable() { ID = userId };
            categoryObj.UpdateCategory(c.Category);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            if (SessionController.UserIsInSession())
            {
                CollectionViewModel cModel = new CollectionViewModel();
                cModel.User = userObj.GetUser(userId);
                cModel.Category = categoryObj.GetCategory(id);
                return View(cModel);
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            categoryObj.DeleteCategory(id);
            return RedirectToAction("Index");
        }
    }
}
