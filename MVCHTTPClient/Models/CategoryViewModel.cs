using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCHTTPClient.ServiceCategory;

namespace MVCHTTPClient.Models
{
    public class CategoryViewModel
    {
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }

    }
}