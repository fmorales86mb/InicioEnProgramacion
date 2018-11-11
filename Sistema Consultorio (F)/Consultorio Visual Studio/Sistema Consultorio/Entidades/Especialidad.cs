using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Especialidad {
        int especialidadId;
        public int EspecialidadId {
            get {
                return especialidadId;
            }
            set {
                especialidadId = value;
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

        // Sobreescribo el ToString para que el combo muestre Nombre.
        public override string ToString() {
            return this.Nombre;
        }        
    }
}
