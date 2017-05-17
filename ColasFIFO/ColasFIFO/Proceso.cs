using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Proceso
    {
        public Proceso()
        {

        }

        private int _nProceso;

        public int nProceso
        {
            set { _nProceso = value; }
            get { return _nProceso; }
        }

        private int _ciclosP;

        public int ciclosP
        {
            set { _ciclosP = value; }
            get { return _ciclosP; }
        }

        private Proceso _anterior;

        public Proceso anterior
        {
            set { _anterior = value; }
            get { return _anterior; }
        }

        private Proceso _siguiente;

        public Proceso siguiente
        {
            set { _siguiente = value; }
            get { return _siguiente; }
        }

        public override string ToString()
        {
            return "Proceso "+_nProceso+ " Ciclos " + _ciclosP + Environment.NewLine;
        }
    }
}
