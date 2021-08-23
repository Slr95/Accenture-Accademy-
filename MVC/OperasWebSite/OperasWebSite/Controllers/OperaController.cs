using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OperasWebSite.Data;
using OperasWebSite.Models;

namespace OperasWebSite.Controllers
{
    public class OperaController : Controller
    {

        //declarar y crear una instancia de EF
        OperaDbContext context = new OperaDbContext();

        // GET: Opera
        // GET /Opera/Index
        public ActionResult Index()
        {
            var operas = context.Operas.ToList();

            return View(operas);
        }

        //GET /Opera/Detail
        public ActionResult Detail(int id)
        {
            var opera = context.Operas.Find(id);

            if (opera != null)
            {
                return View("Detail", opera);
            }
            else
            {
                return HttpNotFound();
            }
        }

        //GET /Opera/Create
        public ActionResult Create()
        {
            Opera opera = new Opera();
            return View("Create", opera);
        }
        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", opera);
            }
        }
    }
}