using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP10.Models;

namespace TP10.Controllers
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
            ViewBag.Mostrar=BD.Mostrar();
            return View();
        }

        [HttpPost]
        public IActionResult ConsultaPadron(int dni){
            ViewBag.Persona=BD.ConsultaPadron(dni);
            ViewBag.Mostrar=BD.Mostrar();
            if(ViewBag.Persona==null){
                ViewBag.NoDNI="Error. DNI no existente";
                return View("Index");
            }else{
                if(ViewBag.Persona.Voto==true){
                    ViewBag.YaVoto="Usted ya ha realizado su voto";
                }
                ViewBag.Establecimiento=BD.ConsultaEstablecimiento(ViewBag.Persona.IdEstablecimiento);
                return View("Votar");
            }
        }
        [HttpPost]
        public IActionResult Votar(int dni, int NumeroTramite){
            ViewBag.Persona=BD.ConsultaPadron(dni);
            ViewBag.Mostrar=BD.Mostrar();
            ViewBag.Establecimiento=BD.ConsultaEstablecimiento(ViewBag.Persona.IdEstablecimiento);
            if(NumeroTramite==ViewBag.Persona.NumeroTramite){
                if(ViewBag.Persona.Voto==true){
                    ViewBag.YaVoto="Usted ya ha realizado su voto";
                    return View();
                }else{
                    ViewBag.Persona.Voto=BD.Votar(dni,NumeroTramite);
                    ViewBag.Correcto="Voto procesado correctamente";
                    return View("Index");
                }
            }else{
                ViewBag.Nocoincide="El número de trámite no coincide con el DNI";
                return View();
            }
        }

        public IActionResult EXP(int IdEstablecimiento){
            ViewBag.EXP=BD.EXP(IdEstablecimiento);
            return View();
        }

        public IActionResult Establecimiento(){
            ViewBag.Establecimiento=BD.Mostrar();
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
