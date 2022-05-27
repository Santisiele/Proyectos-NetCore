using System;
using System.Collections.Generic;

namespace TP10.Models
{
    public class Persona
    {
        private int _DNI;
        private string _Nombre;
        private string _Apellido;
        private int _NumeroTramite;
        private int _IdEstablecimiento;
        private bool _Voto;
        private DateTime _FechaVoto;
        private string _UrlFoto;

        public int DNI{
            set{_DNI=value;}
            get{return _DNI;}
        }

        public string Nombre{
            set{_Nombre=value;}
            get{return _Nombre;}
        }

        public string Apellido{
            set{_Apellido=value;}
            get{return _Apellido;}
        }
        public int NumeroTramite{
            set{_NumeroTramite=value;}
            get{return _NumeroTramite;}
        }
         public int IdEstablecimiento{
            set{_IdEstablecimiento=value;}
            get{return _IdEstablecimiento;}
        }
        public bool Voto{
            set{_Voto=value;}
            get{return _Voto;}
        }
        public DateTime FechaVoto{
            set{_FechaVoto=value;}
            get{return _FechaVoto;}
        }
        public string UrlFoto{
            set{_UrlFoto=value;}
            get{return _UrlFoto;}
        }
        public Persona()
        {
            _DNI=0;
            _Nombre="";
            _Apellido="";
            _NumeroTramite=0;
            _IdEstablecimiento=0;
            _Voto=false;
        }
        public Persona(int DNI, string Nombre, string Apellido, int NumeroTramite, int IdEstablecimiento, bool Voto){
            _DNI=DNI;
            _Nombre=Nombre;
            _Apellido=Apellido;
            _NumeroTramite=NumeroTramite;
            _IdEstablecimiento=IdEstablecimiento;
            _Voto=Voto;
        }
    }
}