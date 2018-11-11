using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

// Tengo que obtener referencia a Datos, que es un proyecto distinto.

namespace Logica
{
    
    public class Empleado {
        Datos.Empleado objDatosEmpleado = new Datos.Empleado();

        public DataTable TraerTodos() {       
            return objDatosEmpleado.TraerTodos();
        }

        public DataTable TraerPaises() {
            return objDatosEmpleado.TraerPaises();
        }

    }
}
