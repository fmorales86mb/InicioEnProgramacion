using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class ObraSocial {
        int obraSocialId;
        public int ObraSocialId {
            get {
                return obraSocialId;
            }
            set {
                obraSocialId = value;
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

        string direccion;
        public string Direccion {
            get {
                return direccion;
            }
            set {
                direccion = value;
            }
        }

        string telefono;
        public string Telefono {
            get {
                return telefono;
            }
            set {
                telefono = value;
            }
        }

        string informacionAdicional;
        public string InformacionAdicional {
            get {
                return informacionAdicional;
            }
            set {
                informacionAdicional = value;
            }
        }

        string cuit;
        public string Cuit {
            get {
                return cuit;
            }
            set {
                cuit = value;
            }
        }

    }
}
