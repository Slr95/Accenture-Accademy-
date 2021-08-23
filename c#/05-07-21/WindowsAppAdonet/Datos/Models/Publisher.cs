using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Publisher
    {
        //SELECT[pub_id], [pub_name], [city], [state], [country] FROM[dbo].[publishers]
        private string pub_id;

         public string Pub_id
        {
            get { return pub_id; }
            set { pub_id = value; }
        }
        private string pub_name;

        public string Pub_name
        {
            get { return pub_name; }
            set { pub_name = value; }
        }
        public string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public Publisher() { }
    }
}
