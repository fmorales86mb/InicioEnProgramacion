using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {

    public class Producto {
        

        public List<Entidades.Producto> TraerTodos() {
            Datos.Producto objDatosProducto = new Datos.Producto();
            return objDatosProducto.TraerTodos();
        }
    }
}
