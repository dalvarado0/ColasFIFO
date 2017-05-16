using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Simulacion
    {

        private int _ciclo = 0, p;
        private static Random _ran = new Random();
        Proceso inicio, ultimo;

        public Simulacion(int ciclo)
        {
            _ciclo = ciclo;
        }

        public string simular()
        {
            int libre = 0;
            for (int i = 1; i <= _ciclo; i++)
            {
                p = probabilidad(1, 101);
                if (p <= 25)
                {
                    crearProceso();
                }
                if (inicio != null)
                {
                    inicio.ciclosP -= 1;
                    if (inicio.ciclosP == 0)
                        inicio = inicio.siguiente;
                }
                else
                    libre += 1;
            }
            return reporte() + Environment.NewLine + "Sin procesar " + libre.ToString();
        }

        private int probabilidad(int min, int max)
        {
            return _ran.Next(min, max);
        }

        private void crearProceso()
        {
            Proceso nuevo = new Proceso();
            p = probabilidad(4, 15);
            nuevo.ciclosP = p;
            agregarProceso(nuevo);
        }

        private void agregarProceso(Proceso nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
                inicio.anterior = null;
                inicio.nProceso = 1;
            }
            else
            {
                nuevo.anterior = ultimo;
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
                ultimo.nProceso = ultimo.anterior.nProceso + 1;
            }
            
        }

        private string reporte()
        {
            string datos = "";
            int contProcesos = 0, contCiclos=0;
            Proceso temp = inicio;
            while(temp != null)
            {
                contProcesos += 1;
                contCiclos += temp.ciclosP;
                temp = temp.siguiente;
                datos = "Procesos pendiente " + contProcesos.ToString() +Environment.NewLine+ "Ciclos faltantes " + contCiclos.ToString();
            }
            return datos;
        }

    }
}
