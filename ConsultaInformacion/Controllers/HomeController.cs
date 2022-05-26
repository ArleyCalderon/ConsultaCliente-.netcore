using ConsultaInformacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace ConsultaInformacion.Controllers
{
    public class HomeController : Controller
    {
        public string variableglobal = "no";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        
        public IActionResult Login()
        {
           
            {
                return View();
            }

        }

        [HttpPost]

        public IActionResult Login([Bind] Ad_Login ad)
        {
            var instance = new Db();
            int res = instance.LoginCheck(ad);
            if (res == 1)
            {
                TempData["msg"] = "Bienvenido";
                variableglobal = "si";
                
                return RedirectToAction("Index", "Home");

            }
            else
            {
                TempData["msg"] = "Usuario o contraseña incorrecta!";
                
            }
            return View();
        }

        public IActionResult Index()
        {
            TempData["msg"] = "Correcto";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
