using MVCHTTPClient.Areas.Admin.Security;
using MVCHTTPClient.LoginReference;
using MVCHTTPClient.Models;
using MVCHTTPClient.UserTableReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHTTPClient.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        LoginServiceClient loginObj = new LoginServiceClient();
        UserTableServiceClient userObj = new UserTableServiceClient();
        
        // GET: Admin/Login
        public ActionResult Index()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginviewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                //Checks if table columns contain the value from login site textboxes
                if (loginObj.UserExist(loginModel.Username, loginModel.Password))
                {
                    //Returns a user object that match the specified username from the login page
                    var user = userObj.GetUserByUsername(loginModel.Username);
                    var login = loginObj.GetLogin(user.Login.ID);

                    SessionController.UserId = user.ID;
                    SessionController.Username = login.Username;
                    
                    //Redirect to user page
                    return RedirectToAction("Index", "Admin");
                }
            }
            return View(loginModel);
        }
    }
}