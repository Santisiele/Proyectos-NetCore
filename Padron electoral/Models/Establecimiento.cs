using System;
using System.Collections.Generic;

namespace TP10.Models
{
    public class Establecimiento
    {
        private int _IdEstablecimiento;
        private string _Nombre;
        private string _Direccion;
        private string _Localidad;

        public int IdEstablecimiento{
            set{_IdEstablecimiento=value;}
            get{return _IdEstablecimiento;}
        }

        public string Nombre{
            set{_Nombre=value;}
            get{return _Nombre;}
        }

        public string Direccion{
            set{_Direccion=value;}
            get{return _Direccion;}
        }
        public string Localidad{
            set{_Localidad=value;}
            get{return _Localidad;}
        }
        public Establecimiento(){
            _IdEstablecimiento=0;
            _Nombre="";
            _Direccion="";
            _Localidad="";

        }
        public Establecimiento(int IdEstablecimiento,string Nombre, string Direccion, string Localidad){
            _IdEstablecimiento=IdEstablecimiento;
            _Nombre=Nombre;
            _Direccion=Direccion;
            _Localidad=Localidad;
        }
    }
}