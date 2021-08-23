using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SistemaWebAlumnos.Models;
using SistemaWebAlumnos.Data;
using System.Data.Entity.Infrastructure;

namespace SistemaWebAlumnos.Controllers
{
    public class AlumnoController : Controller
    {
        AlumnoDbContext context = new AlumnoDbContext();
        // GET: Alumno
        public ActionResult Index()
        {
            var alumno = context.alumnos.ToList();
            return View(alumno);
        }
        public ActionResult Detail(int Id)
        {
            var alumno = context.alumnos.Find(Id);
            if (alumno != null)
            {
                return View("Detail", alumno);
            }
            else
            {
                return HttpNotFound();
            }
        }
        //Create
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
                context.alumnos.Add(alumno);
                context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View("Create", alumno);
            }
        }
        //Delete
        public ActionResult Delete(int Id)
        {
            Alumno alumno = context.alumnos.Find(Id);
            if (alumno != null)
            {
                return View("Delete", alumno);
            }
            return HttpNotFound();
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int Id)
        {
            
            Alumno alumno = context.alumnos.Find(Id);
            
            context.alumnos.Remove(alumno);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //Edit
        public ActionResult Edit(int id)
        {
            var alumno = context.alumnos.Find(id);
            if (alumno != null)
            {
                return View("Edit", alumno);

            }
            else
            {
                return View(alumno);
            }
        }
        [HttpPost]
        public ActionResult Edit(Alumno alumn)
        {
            if (alumn != null)
            {
                context.Entry(alumn).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View(alumn);
            }

        }


    }
}