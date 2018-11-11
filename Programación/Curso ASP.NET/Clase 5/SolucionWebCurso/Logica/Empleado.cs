using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Empleado
    {
        Datos.Empleado objDatosEmpleado = new Datos.Empleado();
        // metodos
        public DataTable TraerTodos()
        {
            return objDatosEmpleado.TraerTodos();

        }

        //Laboratorio DATAVIEW
        public DataTable TraerPaises()
        {
            return objDatosEmpleado.TraerPaises();

        }
    }
}
