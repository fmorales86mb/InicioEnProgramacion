using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class Tratamiento {
        public static List<Entidades.Tratamiento> TablaCompleta() {
            return Datos.Tratamiento.TablaCompleta();
        }

        public static Entidades.Tratamiento BuscarPorId(int id) {
            return Datos.Tratamiento.BuscarPorId(id);
        }
    }
}
