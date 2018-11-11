using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class Cliente {
        Datos.Cliente ObjDatosCliente = new Datos.Cliente();

        public object TraerTodos() {      
            return ObjDatosCliente.TraerTodos();
        }

        public object TraerPaises() {
            return ObjDatosCliente.TraerPaises();
        }

        public object TraerPorPais(string pPais) {
            return ObjDatosCliente.TraerPorPais(pPais);
        }
    }
}
