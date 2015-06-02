using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    private class Nodo
    {
        private int agregar;
        private Nodo numeros;

        private Nodo(int agregar)
        {
            Agregar = agregar;
            Numeros = null;

        }
        private Nodo Numeros
        {
            get {return numeros; }
            set {numeros = value; }
        
         private int Agregar
        {
            get {return agregar; }
            set {agregar= value; }
         }
        }
    }
}
