using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticaFinal.Data;
using PracticaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AutoController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: Traer todos los Autos
        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            return _context.Autos.ToList();
        }

        //POST: Insertar un Auto
        [HttpPost]
        public ActionResult Post(Auto auto)
        {
            _context.Autos.Add(auto);
            _context.SaveChanges();

            return Ok();
        }

        //GET: Traer el Auto por ID  
        [HttpGet("{id}")]
        public ActionResult<Auto> Get(int id)
        {
            return _context.Autos.Find(id);
        }

        //PUT: Modificar un Auto - Realizar la prueba en Postman
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Auto auto)
        {
            if (id != auto.Id)
            {
                return BadRequest();
            }

            _context.Entry(auto).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }

        //DELETE: Eliminar un Auto - Realizar la prueba en Postman
        [HttpDelete("{id}")]
        public ActionResult<Auto> Delete(int id)
        {
            var auto = _context.Autos.Find(id);
            if (auto == null)
            {
                return NotFound();
            }

            _context.Autos.Remove(auto);
            _context.SaveChanges();

            return auto;
        }

        //GET: Traer autos por marca
        [HttpGet("TraerMarca/{marca}")]
        public IEnumerable<Auto> TraerMarca(string marca)
        {
            var auto = (from p in _context.Autos
                            where p.Marca.Contains(marca)
                            select p).ToList();
            return auto;
        }

        //GET: Traer autos por marca y modelo
        [HttpGet("TraerMarcaModelo/{marca}/{modelo}")]
        public IEnumerable<Auto> TraerColor(string marca, string modelo)
        {
            var auto = (from p in _context.Autos
                        where p.Marca.Contains(marca) && p.Modelo.Contains(modelo)
                        select p).ToList();
            return auto;
        }

        //GET: Traer autos por Color
        [HttpGet("TraerColor/{color}")]
        public IEnumerable<Auto> TraerColor(string color)
        {
            var auto = (from p in _context.Autos
                        where p.Color.Contains(color)
                        select p).ToList();
            return auto;
        }

    }
}
