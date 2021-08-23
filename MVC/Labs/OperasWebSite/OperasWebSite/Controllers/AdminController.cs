using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperasWebSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        //GET
        // Admin/Login/gaby/admin
        public ActionResult Login(string user, string role)
        {
            ViewBag.User = user;
            ViewBag.Role = role;

            return View();
        }

        //GET
        //Admin/SearchByTitle/Profesor
        //Admin/title--SI
        public ActionResult SearchByTitle(string title)
        {
            ViewBag.Title = title;
            return View();
        }
    }
}