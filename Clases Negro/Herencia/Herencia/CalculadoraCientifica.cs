using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia {
    class CalculadoraCientifica : Calculadora {
        public int RaizCuadrada (int a) {
            return 0;
        }

        // Esta funcion sobre escribe la funcion del hijo.
        public override int HacerCalculo (int a, int b) {
            return 0;
        }
    }
}
