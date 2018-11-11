using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class ObraSocial {

        public static List<Entidades.ObraSocial> TablaCompleta() {
            return Datos.ObraSocial.TablaCompleta();
        }
    }
}
