using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class EstadoTratamiento {
        int estadoTratamientoId;
        public int EstadoTratamientoId {
            get {
                return estadoTratamientoId;
            }
            set {
                estadoTratamientoId = value;
            }
        }

        string nombre;
        public string Nombre {
            get {
                return nombre;
            }
            set {
                nombre = value;
            }
        }


        string descripcion;
        public string Descripcion {
            get {
                return descripcion;
            }
            set {
                descripcion = value;
            }
        }
    }
}
