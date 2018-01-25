using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Cd> Cds { get; set; }
        public UserTable User { get; set; }
    }
}
