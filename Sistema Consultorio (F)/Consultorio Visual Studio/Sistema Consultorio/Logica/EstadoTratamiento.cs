using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class EstadoTratamiento {
        public static Entidades.EstadoTratamiento BuscarPorId(int id) {
            return Datos.EstadoDeTratamiento.BuscarPorId(id);
        }

        public static List<Entidades.EstadoTratamiento> TablaCompleta() {
            return Datos.EstadoDeTratamiento.TablaCompleta();
        }

        public static int GuardarNuevo(Entidades.EstadoTratamiento obj) {
            return Datos.EstadoDeTratamiento.GuardarNuevo(obj);
        }
    }
}
