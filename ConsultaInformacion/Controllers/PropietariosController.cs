using ConsultaInformacion.Data;
using ConsultaInformacion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConsultaInformacion.Controllers
{
    public class PropietariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PropietariosController(ApplicationDbContext context)
        {
            _context = context;
        }
        //HTPP GET Index
        public IActionResult Index()
        {
            TempData["msg"] = "Correcto";
            IEnumerable<Propietario> listPropietarios = _context.propietario;
            return View(listPropietarios);
        }

        //HTPP GET CREATE
        public IActionResult Create()
        {
            TempData["msg"] = "Correcto";
            return View();
        }

        //HTPP POST CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Propietario propietario)
        {
            if(ModelState.IsValid)
            {
                _context.propietario.Add(propietario);
                _context.SaveChanges();

                TempData["mensaje"] = "El propietario se ha creado correctamente";
                TempData["msg"] = "Correcto";
                return RedirectToAction("Index");
            }
            TempData["msg"] = "Correcto";
            return View();
        }

        //HTPP GET Edit
        public IActionResult Edit(int? id)
        {
            if(id == null || id==00)
            {
                return NotFound();
            }

            var propietario = _context.propietario.Find(id);
            if(propietario==null)
            {
                return NotFound();
            }
            TempData["msg"] = "Correcto";
            return View(propietario);
        }

        //HTPP POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Propietario propietario)
        {
            if (ModelState.IsValid)
            {
                _context.propietario.Update(propietario);
                _context.SaveChanges();

                TempData["mensaje"] = "El propietario se ha actualizado correctamente";
                TempData["msg"] = "Correcto";
                return RedirectToAction("Index");
            }
            return View();
        }

        //HTPP GET Edit
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 00)
            {
                TempData["msg"] = "Correcto";
                return NotFound();
            }

            var propietario = _context.propietario.Find(id);
            if (propietario == null)
            {
                TempData["msg"] = "Correcto";
                return NotFound();
            }
            TempData["msg"] = "Correcto";
            return View(propietario);
        }

        //HTPP POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePropietario(int? id)
        {
            var propietario = _context.propietario.Find(id);
            
            if(propietario == null)
            {
                return NotFound();
            }
  
             _context.propietario.Remove(propietario);
             _context.SaveChanges();

             TempData["mensaje"] = "El propietario se ha eliminado correctamente";
            TempData["msg"] = "Correcto";
            return RedirectToAction("Index");
        }
    }
}

