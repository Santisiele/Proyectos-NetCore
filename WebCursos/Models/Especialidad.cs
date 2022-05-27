using System;
using System.Collections.Generic;

namespace TP11.Models
{
    public class Especialidad
    {
        private int _IdEspecialidad;
        private string _Nombre;
        private string _Materia;
        
        public int IdEspecialidad{
            set{_IdEspecialidad=value;}
            get{return _IdEspecialidad;}
        }

        public string Nombre{
            set{_Nombre=value;}
            get{return _Nombre;}
        }

        public string Materia{
            set{_Materia=value;}
            get{return _Materia;}
        }
    }
}