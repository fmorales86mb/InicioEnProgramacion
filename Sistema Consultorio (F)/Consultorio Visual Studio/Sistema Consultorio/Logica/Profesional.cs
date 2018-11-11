using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class Profesional {        

        public static List<Entidades.Profesional> TablaCompleta () {
            return Datos.Profesional.TablaCompleta();
        }

        public static Entidades.Profesional BuscarPorId(int id) {
            return Datos.Profesional.BuscarPorId(id);
        }

        public static int Guardar(Entidades.Profesional obj) {
            return Datos.Profesional.Guardar(obj);
        }
    }
}
