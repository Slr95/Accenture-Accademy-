using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Publisher
    {
        //SELECT pub_id ,pub_name ,city ,state ,country FROM dbo.publishers
        public string Pub_id { get; set; }
        public string Pub_name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
