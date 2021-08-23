using SistemaWebAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebAlumnos.Controllers
{
    public class AlumnoController : Controller
    {
        private AlumnosContext context = new AlumnosContext();
        // GET: Alumno
      
        //Index()
        public ActionResult Index()
        {
            List<Alumno> lista = context.Alumnos.ToList();
            return View("Index", lista);
        }

        //create()
        public ActionResult Create()
        {
            Alumno alumno = new Alumno();
            return View("Create", alumno);
        }
        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                context.Alumnos.Add(alumno);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else return View("Create", alumno);
        }

        // GET: Alumno/Delete 
        public ActionResult Delete(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View("Delete", alumno);
        }

        // POST: Alumno/Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);
            context.Alumnos.Remove(alumno);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //Details()
        public ActionResult Details(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);
            if (alumno == null)
                return HttpNotFound();
            return View("Detail", alumno);
        }

    }
}