using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP11.Models;

namespace TP11.Controllers
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
            ViewBag.Cursos = BD.ListarCursos(-1);
            ViewBag.Especialidad = BD.ListaEspecialidades();
            return View();
        }

        public IActionResult MostarCursosXEspecialidad(int IdEspecialidad){
            ViewBag.Cursos = BD.ListarCursos(IdEspecialidad);
            ViewBag.Especialidad = BD.ListaEspecialidades();
            return View("Index");
        }

        public IActionResult VerCurso(int IdCurso){
            ViewBag.Curso = BD.ConsultaCurso(IdCurso);
            return View("DetalleCurso");
        }

        public IActionResult Calificar(int IdCurso, bool Like){
            BD.CalificarCurso(IdCurso, Like);
            ViewBag.Curso = BD.ConsultaCurso(IdCurso);
            return View("DetalleCurso");
        }

        public IActionResult AgregarCurso(){
            ViewBag.Especialidad = BD.ListaEspecialidades();
            return View("AgregarCurso");
        }

        [HttpPost]
        public IActionResult GuardarCurso(string Nombre, string Descripcion, string Imagen, string UrlCurso, int IdEspecialidad){
            Curso MiCurso = new Curso(0, Nombre, Descripcion, Imagen, UrlCurso, 0, 0, IdEspecialidad);
            BD.AgregarCurso(MiCurso);
            ViewBag.Especialidad = BD.ListaEspecialidades();
            ViewBag.Cursos = BD.ListarCursos(-1);
            return View("Index");
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
