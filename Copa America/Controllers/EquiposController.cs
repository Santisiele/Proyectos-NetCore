using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP6.Models;


    public class EquiposController : Controller
    {
       public IActionResult VerEquipos()
        {
            string[] Equipos = {"Argentina","Bolivia","Brasil","Chile","Colombia","Ecuador","Paraguay","Peru","Uruguay","Venezuela"};
            ViewBag.Equipos = Equipos;
            return View();
        }

        public IActionResult VerJugadoresEquipos(string equipo)
        {
            ViewBag.Equipos = equipo;
            switch (equipo){
                case "Argentina" : 
                string [] Jugadores1 = {"Lionel Messi","Tagliafico","Kun Agüero","Di Maria","Lautaro Martinez","Leandro Paredes","Franco Armani","Martinez Quarta","Lucas Alario","Gonzalo Montiel","Rodrigo De Paul"};
                string [] EquiJugadores1 = {"Barcelona","Ajax de Amsterdam","Barcelona","PSG","Inter Milan","PSG","River Plate","Calcio Firenze Fiorentina","Bayer Leverkusen","River Plate","Real Betis Balompie"};
                ViewBag.Jugadores = Jugadores1;
                ViewBag.EquiJugadores = EquiJugadores1;
                break;

                case "Bolivia" : 
                string [] Jugadores2 = {"Marcelo Martins", "Carlos Lampe", "Alejandro Chumacero", "Jaume Cuellar", "Diego Bejarano", "Henry Vaca", "Erwin Saavedra", "Adrian Jusino", "Luis Haquin", "Gilbert Alvarez", "Diego Wayar"};
                string [] EquiJugadores2 = {"Cruzeiro", "Always Ready", "Union Española", "SPAL", "Club Bolivar", "Deportivo Oriente Petrolero", "Club Bolivar", "AE Larisa", "Club Deportes Melipilla", "Wilstermann", "The Strongest"};
                ViewBag.Jugadores = Jugadores2;
                ViewBag.EquiJugadores = EquiJugadores2;
                break;
        
                case "Brasil" : 
                string [] Jugadores3 = {"Neymar", "Everton Soares", "Thiago Silva", "Gabriel Barbosa", "Douglas Luiz", "Gabriel Jesus", "Alisson Becker", "Vinicius Junior", "Dani Alves", "Alex Sandro", "Richarlison"};
                string [] EquiJugadores3 = {"PSG", "Sports Lisboa", "Chelsea", "Flamengo", "Aston Villa", "Manchester City", "Liverpool", "Real Madrid", "Sao Pablo", "Juventus", "Everton"};
                ViewBag.Jugadores = Jugadores3;
                ViewBag.EquiJugadores = EquiJugadores3;
                break;
        
                case "Chile" : 
                string [] Jugadores4 = {"Alexis Sanchez", "Arturo Vidal", "Ben Brereton", "Claudio Bravo", "Eduardo Vargas", "Carlos Nuñes", "Jean Meneses", "Gary Mendel", "Guillermo Maripan", "Francisco Sierralta", "Mauricio Isla"};
                string [] EquiJugadores4 = {"Inter Milan", "Inter Milan", "Blackburn Rovers", "Real Betis", "Club Atletico Mineiro", "Club International", "Club Leon", "Bologna Football", "Monaco", "Watford Football Club", "Flamengo"};
                ViewBag.Jugadores = Jugadores4;
                ViewBag.EquiJugadores = EquiJugadores4;
                break;
           
                case "Colombia" : 
                string [] Jugadores5 = {"Rafael Borre", "Edwin Cardona", "James Rodriguez", "Juanfer Quintero", "David Ospina", "Santiago Arias", "Luis Muriel", "Alfredo Morelos", "Gustavo Cuellar", "Davinson Sanchez", "Stefan Medina"};
                string [] EquiJugadores5 = {"River Plate", "Boca Juniors", "Everton Football", "Shenzhen Football", "Calcio Napoli", "Bayer Leverkusen", "Atalanta Bergamasca", "Rangers Football", "Al-Hilal FC", "Tottenham Hotspur", "Futbol Monterrey"};
                ViewBag.Jugadores = Jugadores5;
                ViewBag.EquiJugadores = EquiJugadores5;
                break;
            
                case "Ecuador" : 
                string [] Jugadores6 = {"Enner Valencia", "Gonzalo Plata", "Leonardo Campana", "Damian Diaz", "Ayrton Preciado", "Robert Arboleda", "Alexander Dominguez", "Carlos Gruezo", "Angle Mena", "Fidel Martinez", "Hernan Galindez", };
                string [] EquiJugadores6 = {"Fenerbahçe Spor Kulübü", "Sporting de Lisboa", "FC Famalicao", "Barcelona Sporting", "Santos Languna", "Sao Paulo Futebol", "Velez Sarsfield", " F. C. Augsburgo", "Club Leon", "Club Tijuana", " Club Deportivo de la Universidad Católica" };
                ViewBag.Jugadores = Jugadores6;
                ViewBag.EquiJugadores = EquiJugadores6;
                break;
            
                case "Paraguay" : 
                string [] Jugadores7 = {"Ángel Romero Villamayor", "Alejandro Romero Gamarra", "Miguel Almirón", "Gabriel Ávalos", "Gustavo Gómez Portillo", "Braian Samudio", "Antony Silva", "Richard Sánchez", "Junior Alonso", "Santiago Arzamendia", "Robert Rojas"};
                string [] EquiJugadores7 = {"Club Atlético San Lorenzo de Almagro", "Al-Taawon FC", "Newcastle United Football Club", "Argentinos Juniors", "Palmeiras", "Toluca de la Liga MX de México", "Club Puebla", "Club America", "Mineiro", "Cerro Porteño","River Plate" };
                ViewBag.Jugadores = Jugadores7;
                ViewBag.EquiJugadores = EquiJugadores7;
                break;
           
                case "Peru" : 
                string [] Jugadores8 = {"Gianluca Lapadula", "Paolo Guerrero", "Santiago Ormeño", "Renato Tapia", "Carlos Augusto Zambrano", "André Carrillo", "Edison Flores", "Pedro Gallese", "Andy Polo", "Marcos Johan López", "Miguel Trauco"};
                string [] EquiJugadores8 = {"Benevento Calcio", "Sport Club Internacional", "Club Leon", "Celta de Vigo", "Boca Juniors", "Al-Hilal FC", "D.C United", "Orlando City", "Portland Timbers", "San Jose Earthquakes", " Association Sportive de Saint-Étienne"};
                ViewBag.Jugadores = Jugadores8;
                ViewBag.EquiJugadores = EquiJugadores8;
                break;
            
                case "Uruguay" : 
                string [] Jugadores9 = {"Luis Suarez", "Nicolas de la Cruz", "Edinson Cavani", "Fernando Muslera", "Diego Godín", "Giorgian De Arrascaeta", "Lucas Torreira", "Darwin Nuñez", "Nahitan Nandez", "Matías Vecino", "Giovanni González Apud"};
                string [] EquiJugadores9 = {"Atletico Madrid", "River Plate", "Manchester United", "Galatasaray Spor Kulübü", "Cagliari Calcio", "Flamengo", "Atletico Madrid", " Sport Lisboa e Benfica", "Boca Juniors", "Inter Milan", "Peñarol" };
                ViewBag.Jugadores = Jugadores9;
                ViewBag.EquiJugadores = EquiJugadores9;
                break;
            
                case "Venezuela" : 
                string [] Jugadores10 = {"Wuilker Faríñez", "Yeferson Soteldo", "Salomón Rondón", "Josef MArtinez", "Tomás Rincón", "Juanpi", "Jan Hurtado", "Yordan Osorio", "Luis Mago", "Júnior Moreno", "Jhon Murillo"};
                string [] EquiJugadores10 = {"Racing Club", "Santos", "PFC CSKA Moscú", "Atlanta United", "Torino Football Club", "Al-Ain FC", "Red Bull", "Parma Calcio", "Club Universidad de Chile", "D.C United", "CD Tondela" };
                ViewBag.Jugadores = Jugadores10;
                ViewBag.EquiJugadores = EquiJugadores10;
                break;
            }

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