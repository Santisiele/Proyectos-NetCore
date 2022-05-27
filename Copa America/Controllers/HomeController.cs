using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP6.Models;

namespace TP6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult sedes()
        {
            string[] verSedes = new string [5]{"Arena Pantanal", "Mané Garrincha", "Maracaná", "Nilton Santos", "Olimpico"};

            ViewBag.verSedes = verSedes;
            return View();
        }

        public IActionResult UltimosCampeones()
        {
            return View();
        }

        public IActionResult Goles()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GuardarGanador(string Nombre, string Email, string Ganador)
        {
            // Guardar la consulta del usuario en una base de datos o enviarnos por mail
            
            ViewBag.Nombre = Nombre;
            ViewBag.Ganador = Ganador;
            return View("GraciasGanador");
        }

    }
}
