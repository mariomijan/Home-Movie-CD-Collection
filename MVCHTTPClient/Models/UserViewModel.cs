using System;
using System.Collections.Generic;
using MVCHTTPClient.ServiceUserTable;
using System.Linq;
using System.Web;

namespace MVCHTTPClient.Models
{
    public class UserViewModel
    {
        public UserTable User { get; set; }
        public List<UserTable> users { get; set; }

    }
}