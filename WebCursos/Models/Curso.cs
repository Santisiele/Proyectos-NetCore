using System;
using System.Collections.Generic;

namespace TP11.Models
{
    public class Curso
    {
        private int _IdCurso;
        private string _Nombre;
        private int _IdEspecialidad;
        private string _Descripcion;
        private string _Imagen;
        private string _UrlCurso;
        private int _MeGusta;
        private int _NoMeGusta;

        public int IdCurso{
            set{_IdCurso=value;}
            get{return _IdCurso;}
        }

        public string Nombre{
            set{_Nombre=value;}
            get{return _Nombre;}
        }

        public int IdEspecialidad{
            set{_IdEspecialidad=value;}
            get{return _IdEspecialidad;}
        }
        public string Descripcion{
            set{_Descripcion=value;}
            get{return _Descripcion;}
        }
         public string Imagen{
            set{_Imagen=value;}
            get{return _Imagen;}
        }
        public string UrlCurso{
            set{_UrlCurso=value;}
            get{return _UrlCurso;}
        }
        public int MeGusta{
            set{_MeGusta=value;}
            get{return _MeGusta;}
        }
        public int NoMeGusta{
            set{_NoMeGusta=value;}
            get{return _NoMeGusta;}
        }

        public Curso(){

        }

        public Curso(int IdCurso,string Nombre, string Descripcion, string Imagen, string UrlCurso, int MeGusta, int NoMeGusta, int IdEspecialidad){
            _IdCurso=IdCurso;
            _Nombre = Nombre;
            _Descripcion=Descripcion;
            _Imagen=Imagen;
            _UrlCurso=UrlCurso;
            _MeGusta=MeGusta;
            _NoMeGusta=NoMeGusta;
            _IdEspecialidad=IdEspecialidad;
        }
    }
}