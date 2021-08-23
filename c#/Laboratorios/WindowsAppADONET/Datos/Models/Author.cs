using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Author
    {
        //"SELECT au_id, au_lname ,au_fname ,phone ,address ,city ,state ,zip ,contract FROM dbo.authors";
        //Autoimplementada
        public string Au_id { get; set; }
        public string Au_lname { get; set; }
        public string Au_fname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool Contract { get; set; }

        //completa o prop full EJEMPLO PARA TENER EN CUENTA
        //private string au_id;

        //public string Au_id
        //{
        //    get { return au_id; }
        //    set { au_id = value; }
        //}

        //private string au_lname;

        //public string Au_lname
        //{
        //    get { return au_lname; }
        //    set { au_lname = value; }
        //}

        //private string au_fname;

        //public string Au_fname
        //{
        //    get { return au_fname; }
        //    set { au_fname = value; }
        //}

        //private string phone;

        //public string Phone
        //{
        //    get { return phone; }
        //    set { phone = value; }
        //}
        //private string address;

        //public string Address
        //{
        //    get { return address; }
        //    set { address = value; }
        //}
        //private string city;

        //public string City
        //{
        //    get { return city; }
        //    set { city = value; }
        //}
        //private string state;
        //public string State
        //{
        //    get { return state; }
        //    set { state = value; }
        //}

        //private string zip;

        //public string Zip
        //{
        //    get { return zip; }
        //    set { zip = value; }
        //}
        //private bool contract;

        //public bool Contract
        //{
        //    get { return contract; }
        //    set { contract = value; }
        //}


    }
}
