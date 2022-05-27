using System;
using System.Collections.Generic;

namespace TP10.Models
{
    public class EstablecimientoXPersona
    {
        private string _NombrePersona;
        private string _Apellido;
        private int _IdEstablecimiento;
        private bool _Voto;
        private string _Direccion;
        private string _Localidad;
        private string _NombreEstablecimiento;

        public string NombrePersona{
            set{_NombrePersona=value;}
            get{return _NombrePersona;}
        }

        public string Apellido{
            set{_Apellido=value;}
            get{return _Apellido;}
        }
        public int IdEstablecimiento{
            set{_IdEstablecimiento=value;}
            get{return _IdEstablecimiento;}
        }
        public bool Voto{
            set{_Voto=value;}
            get{return _Voto;}
        }
        public string NombreEstablecimiento{
            set{_NombreEstablecimiento=value;}
            get{return _NombreEstablecimiento;}
        }

        public string Direccion{
            set{_Direccion=value;}
            get{return _Direccion;}
        }
        public string Localidad{
            set{_Localidad=value;}
            get{return _Localidad;}
        }
    }
}