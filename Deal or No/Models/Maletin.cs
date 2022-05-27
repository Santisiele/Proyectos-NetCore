using System;

namespace TP8.Models
{
    public class Maletin
    {
        private int _numeroMaletin;
        private int _importe;
        private bool _estado;

        public int numeroMaletin { 
            get { return _numeroMaletin;}
        }
        public int importe { 
            get { return _importe;}
        }
        public bool estado {
            get { return _estado;}
            set { _estado = value;}
        }

        public Maletin(int numeroMaletin, int importe)
        {
            _estado = false;
            _importe = importe;
            _numeroMaletin=numeroMaletin;
        }
    }
}