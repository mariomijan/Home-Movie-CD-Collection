using Microsoft.AspNet.Identity;
using MVCHTTPClient.UserTableReference;
using MVCHTTPClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCHTTPClient.Areas.Admin.Security
{ 
    public static class SessionController
    {
        //Session, Set and Get the userId
        public static int UserId
        {
            get
            {
                if (HttpContext.Current.Session["session"] != null)
                    return (int)HttpContext.Current.Session["session"];
                else
                    return 0;
            }

            set
            {
                HttpContext.Current.Session["session"] = value;
            }
        }

        public static string Username
        {
            get
            {
                if (HttpContext.Current.Session["sessionUsername"] != null)
                    return HttpContext.Current.Session["sessionUsername"].ToString();
                else
                    return null;
            }

            set
            {
                HttpContext.Current.Session["sessionUsername"] = value;
            }
        }

        //Check if user is in session
        public static bool UserIsInSession()
        {
            if (UserId != 0)
            {
                return true;
            }
            return false;
        }
        
        //Close the session
        public static void CloseSession()
        {
            HttpContext.Current.Session.Abandon();
        }
    }
}
