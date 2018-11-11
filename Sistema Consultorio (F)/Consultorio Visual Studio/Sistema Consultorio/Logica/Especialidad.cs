using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class Especialidad
    {        

        public static List<Entidades.Especialidad> TablaCompleta() {            
            return Datos.Especialidad.TablaCompleta();
        }

        public static Entidades.Especialidad BuscarPorId(int id) {
            return Datos.Especialidad.BuscarPorId(id);
        }

        public static int GuardarNuevo(Entidades.Especialidad obj) {
            return Datos.Especialidad.GuardarNuevo(obj);
        }
    }
}
