using System;
using System.Collections.Generic;

namespace TP8.Models
{
    public static class DealOrNO
    {
        public static List<int> ImportesDescartados = new List<int>();
        private static Maletin[] _Maletines;
        private static Maletin _MaletinElegido;
        private static int[] _Importes;
        private static int _Jugadas;
        private static int _Turno;
        private static double _Oferta;
        private static int _Acumulador;
        private static int _CantMal;
        private static int _CantOfe;


        public static Maletin MaletinElegido { 
            get { return _MaletinElegido;}
        }

        public static void IniciarJuego(int MaletinEle){
            ImportesDescartados = new List<int>();
            _CantOfe=0;
            _Jugadas = 6;
            _Turno =6;
            _Importes =  new int[26] {1,5,10,15,25,50,75,100,200,300,400,500,750,1000,5000,10000,25000,50000,75000,100000,200000,300000,400000,500000,750000,1000000};
            _Maletines = new Maletin[26];
            
            for(int i=0;i<26;i++)
            {
                Random rnd=new Random();
                int nro = rnd.Next(0,26);
                while (_Importes[nro]==-1)
                {
                    nro = rnd.Next(0,26);
                }
                Maletin MaletinTemporal = new Maletin(i,_Importes[nro]);
                _Maletines[i] = MaletinTemporal;
                _Importes[nro] = -1;
            }

            _MaletinElegido = _Maletines[MaletinEle];
            _MaletinElegido.estado=true;
        }
    
        public static int AbrirMaletin(int Numero)
        {
            if(_Maletines[Numero].estado==false){
                _Maletines[Numero].estado=true;
                _Jugadas--;
                ImportesDescartados.Add(_Maletines[Numero].importe);
                return _Maletines[Numero].importe;
            }else{
                return -1;
            }
        }

        public static int JugadasRestantes(){
            return _Jugadas;
        }

        public static double ofertaBanca(){
            _Oferta =0;
            _CantMal=0;
            _Acumulador= 0;
            if(_Jugadas==0){
                for(int c=0; c<26;c++){
                    if(_Maletines[c].estado==false){
                    _Acumulador= _Acumulador + _Maletines[c].importe;
                    _CantMal++;
                    }
                }
            _Oferta=_Acumulador/_CantMal*0.85;
            _CantOfe++;
            }
            return _Oferta;
        }
        
        public static int decisionOferta(string aceptar){
            if(aceptar=="true"){
                return MaletinElegido.importe;
            }else if(aceptar=="false"){
                _Turno--;
                if(_Turno<=0){
                    _Jugadas=1;
                }
                else
                {
                    _Jugadas = _Turno;
                }
                return -1;
            }else{
                return -2;
            }
        }

        public static Maletin[] DevolverListaMaletines(){
            return _Maletines;
        }

        public static int[] DevolverListaImportes(){
            _Importes =  new int[26] {1,5,10,15,25,50,75,100,200,300,400,500,750,1000,5000,10000,25000,50000,75000,100000,200000,300000,400000,500000,750000,1000000};
            return _Importes;
        }

        public static int DevolverOfertas(){
            return _CantOfe;
        }

        public static int DevolverImporteMaletinEle(){
            return _MaletinElegido.importe;
        }
        
    }
}