using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP7.Models;namespace TP7.Controllers
{
    public class EscapeController : Controller
    {
        static int errores=0;
        static string nombre;
        private readonly ILogger<EscapeController> _logger;

        public EscapeController(ILogger<EscapeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.MostrarNavBarJuego = false;
            return View();
        }


         public IActionResult Habitacion1(string nombreUs)
        {
            nombre=nombreUs;
            ViewBag.nombreUsuario=nombre;
            errores=0;
            ViewBag.MostrarNavBarJuego = true;
            ViewBag.Alerta= false;
            ViewBag.Habitacion1=true;
            return View();
        }
        [HttpPost]
        
        public IActionResult Habitacion1(int clave)
        {
            errores=0;
            ViewBag.nombreUsuario=nombre;
            if (clave == 751942160){
                ViewBag.Habitacion2=true;
                return View("Habitacion2");
            }
            else{
                errores++;
                ViewBag.Alerta= true;
                ViewBag.Habitacion1=true;
                return View();
            }
      
        }

        [HttpPost]
         public IActionResult Habitacion2(string clave)
        {
            ViewBag.nombreUsuario=nombre;
            ViewBag.MostrarNavBarJuego = true;
            ViewBag.Habitacion2=true;
            if (clave == "15/11/1967"){
                ViewBag.Habitacion3=true;
                return View("Habitacion3");
            }
            else {
                errores++;
                ViewBag.Alerta= true;
                ViewBag.Habitacion2=true;
                return View("Habitacion2");
            }
        }

        [HttpPost]
         public IActionResult Habitacion3(string clave)
        {
            ViewBag.nombreUsuario=nombre;
            ViewBag.MostrarNavBarJuego = true;
            ViewBag.Habitacion3=true;
            if (clave == "harina" || clave== "Harina"){
                ViewBag.Habitacion4=true;
                return View("Habitacion4");
            }
            else{
                errores++;
                ViewBag.Alerta= true;
                ViewBag.Habitacion3=true;
                return View();
            }
        }
        
        [HttpPost]
         public IActionResult Habitacion4(string clave)
        {
            ViewBag.nombreUsuario=nombre;
            ViewBag.MostrarNavBarJuego = true;
            ViewBag.Habitacion4=true;
            if (clave == "blanco" || clave == "Blanco"){
                ViewBag.Victoria=true;
                ViewBag.cantErrores=errores;
                ViewBag.MostrarNavBarJuego = false;
                return View("Victoria");
            }
            else{
                errores++;
                ViewBag.Alerta= true;
                ViewBag.Habitacion4=true;
                return View();
            }
        }
        [HttpPost]
         public IActionResult Victoria()
        {
            ViewBag.nombreUsuario=nombre;
            ViewBag.MostrarNavBarJuego = false;
            ViewBag.Victoria=true;
            return View();
        }
    }
}