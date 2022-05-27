using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP8.Models;

namespace TP8.Controllers
{
    public class JuegoController : Controller
    {
        private readonly ILogger<JuegoController> _logger;

        public JuegoController(ILogger<JuegoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Importes=DealOrNO.DevolverListaImportes();
            return View();
        }
        public IActionResult elegirPrimerMaletin(int maletinP)
        {
            ViewBag.ImporteMaletin=0;
            if((maletinP>26) || (maletinP<0)){
                ViewBag.Mensaje=1;
                ViewBag.Maletines=DealOrNO.DevolverListaMaletines();
                ViewBag.Importes=DealOrNO.DevolverListaImportes();
                ViewBag.JugadasRestantes=DealOrNO.JugadasRestantes();
                return View("Index");
            }else{
                DealOrNO.IniciarJuego(maletinP);
                ViewBag.Maletines=DealOrNO.DevolverListaMaletines();
                ViewBag.Importes=DealOrNO.DevolverListaImportes();
                ViewBag.JugadasRestantes=DealOrNO.JugadasRestantes();
                ViewBag.ImportesDescartados=DealOrNO.ImportesDescartados;
                return View("Juego");
            }
        }

        public IActionResult eleccionMaletin(int maletin)
        {
             ViewBag.ImporteMaletin=0;
            if((maletin>26) || (maletin<0)){
                ViewBag.Mensaje=1;
                ViewBag.Maletines=DealOrNO.DevolverListaMaletines();
                ViewBag.Importes=DealOrNO.DevolverListaImportes();
                ViewBag.JugadasRestantes=DealOrNO.JugadasRestantes();
                ViewBag.ImportesDescartados=DealOrNO.ImportesDescartados;
                return View("Juego");
            }else{
                ViewBag.Maletines=DealOrNO.DevolverListaMaletines();
                ViewBag.Importes=DealOrNO.DevolverListaImportes();
                ViewBag.ImporteMaletin= DealOrNO.AbrirMaletin(maletin);
                ViewBag.JugadasRestantes=DealOrNO.JugadasRestantes();
                ViewBag.ImportesDescartados=DealOrNO.ImportesDescartados;
                if(ViewBag.ImporteMaletin==-1){
                    ViewBag.Mensaje=2;
                    return View("Juego");
                }else{
                    if(ViewBag.JugadasRestantes==0){
                        ViewBag.Banca=DealOrNO.ofertaBanca();
                        return View("Decision");

                    }else{
                        return View("Juego");
                    }           
                }
            }

        }

        public IActionResult Decision(string decision, int a, int CantOfer)
        {
            a= DealOrNO.decisionOferta(decision);
            ViewBag.ImportesDescartados=DealOrNO.ImportesDescartados;
            ViewBag.ImporteMaletin=0;
            if(a==-1){
                ViewBag.Maletines=DealOrNO.DevolverListaMaletines();
                ViewBag.Importes=DealOrNO.DevolverListaImportes();
                ViewBag.JugadasRestantes=DealOrNO.JugadasRestantes();
                CantOfer=DealOrNO.DevolverOfertas();
                if(CantOfer==9){
                    ViewBag.Final=DealOrNO.DevolverImporteMaletinEle();
                return View("Final"); 
                }
                return View("Juego");
            }else if(a>0){
                ViewBag.Final=DealOrNO.ofertaBanca();
                return View("Final");
            }else{
                ViewBag.Mensaje=3;
                ViewBag.Maletines=DealOrNO.DevolverListaMaletines();
                ViewBag.Importes=DealOrNO.DevolverListaImportes();
                ViewBag.JugadasRestantes=DealOrNO.JugadasRestantes();
                ViewBag.Banca=DealOrNO.ofertaBanca();
                return View("Decision");
            }
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
