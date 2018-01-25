using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCHTTPClient.ServiceCd;

namespace MVCHTTPClient.Models
{
    public class CdViewModel
    {
        public List<Cd> Cds { get; set; }
        public Cd Cd { get; set; }
    }
}