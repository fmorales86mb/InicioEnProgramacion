using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia {
    class Calculadora {
        protected int Memoria;                  // esta la puedo ver desde las clases hijas.
        public int Version;                     // Esta la puede ver todo el  mundo.
        private int ResultadoIntermedio;        // esta solo la puede ver Calculadora.

        public int Sumar (int a, int b) {
            return a + b;
        }

        public int Multiplicar (int a, int b) {
            return a * b;
        }


        // Esta funncion puede ser sobre escrita por un hijo.
        public virtual int HacerCalculo (int a, int b) {
            return 123;
        }

        public virtual string Buscar (string clave) {
            return null;
        }

        public virtual void Agregar (string clave, string valor) {
        }
    }
}
