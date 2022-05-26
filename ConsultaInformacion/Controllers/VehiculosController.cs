using ConsultaInformacion.Data;
using ConsultaInformacion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConsultaInformacion.Controllers
{
    public class VehiculosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VehiculosController(ApplicationDbContext context)
        {
            _context = context;
        }
        //HTPP GET Index
        public IActionResult Index()
        {
            TempData["msg"] = "Correcto";
            IEnumerable<Vehiculo> listVehiculos = _context.vehiculo;
            return View(listVehiculos);
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
        public IActionResult Create(Vehiculo vehiculo)
        {
            if(ModelState.IsValid)
            {
                _context.vehiculo.Add(vehiculo);
                _context.SaveChanges();

                TempData["mensaje"] = "El vehículo se ha creado correctamente";
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

            var vehiculo = _context.vehiculo.Find(id);
            if(vehiculo == null)
            {
                
                return NotFound();
            }
            TempData["msg"] = "Correcto";
            return View(vehiculo);
        }

        //HTPP POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.vehiculo.Update(vehiculo);
                _context.SaveChanges();

                TempData["mensaje"] = "El Vehículo se ha actualizado correctamente";
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

            var vehiculo = _context.vehiculo.Find(id);
            if (vehiculo == null)
            {
                TempData["msg"] = "Correcto";
                return NotFound();
            }
            TempData["msg"] = "Correcto";
            return View(vehiculo);
        }

        //HTPP POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePropietario(int? id)
        {
            var vehiculo = _context.vehiculo.Find(id);
            
            if(vehiculo == null)
            {
                
                return NotFound();
            }
  
             _context.vehiculo.Remove(vehiculo);
             _context.SaveChanges();

             TempData["mensaje"] = "El vehiculo se ha eliminado correctamente";
            TempData["msg"] = "Correcto";
            return RedirectToAction("Index");
        }
    }
}

