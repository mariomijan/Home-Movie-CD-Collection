using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Core
{
    [DataContract]
    public class Cd
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]

        public string Name { get; set; }
        [DataMember]

        public string Description { get; set; }
        [DataMember]

        public Genre Genre { get; set; }
        [DataMember]

        public string Image { get; set; }
        [DataMember]

        public UserTable User { get; set; }

    }
}
