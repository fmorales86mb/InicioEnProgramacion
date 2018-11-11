using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class TipoPaciente {
        int tipoPacienteId;
        public int TipoPacienteId {
            get {
                return tipoPacienteId;
            }
            set {
                tipoPacienteId = value;
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
