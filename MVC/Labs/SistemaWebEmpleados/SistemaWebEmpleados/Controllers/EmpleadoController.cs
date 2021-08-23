using SistemaWebEmpleados.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaWebEmpleados.Models;
using System.Data.Entity;

namespace SistemaWebEmpleados.Controllers
{
    public class EmpleadoController : Controller
    {
        EmpleadoDbContext context = new EmpleadoDbContext();

        // GET: Empleado
        // /Empleado/Index
        public ActionResult Index()
        {
            var empleados = context.Empleados.ToList();
            return View(empleados);
        }

        //GET: /Empleado/Detail/id
        //[HttpGet] implicito no es necesario
        public ActionResult Detail(int id)
        {
            Empleado empleado = context.Empleados.Find(id);

            if (empleado != null)
            {
                return View("Detail", empleado);
            }
            else
            {
                return HttpNotFound();
            }
        }

        //envio formulario de creacion
        //GET: /Empleado/Create
        public ActionResult Create()
        {
            Empleado empleado = new Empleado();

            return View("Create", empleado);
        }

        //POST: en la etiqueta form html 
        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                //devuelve con opera para que lo edite 
                return View("Create", empleado);
            }

        }

        // /Empleadp/Delete/4
        public ActionResult Delete(int id)
        {
            Empleado empleado = context.Empleados.Find(id);
            if (empleado != null)
            {
                return View("Delete", empleado);
            }
            else
            {
                return HttpNotFound();
            }

        }

        
        [HttpPost]
        public ActionResult Delete(Empleado empleado)
        {
            if (empleado != null)
            {
                context.Entry(empleado).State = EntityState.Modified;
                context.Empleados.Remove(empleado);
                context.SaveChanges();
            }
            return View(empleado);
        }

    }
}