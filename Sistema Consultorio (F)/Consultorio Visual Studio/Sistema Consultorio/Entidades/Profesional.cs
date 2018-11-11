using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Profesional {

        List<Entidades.Especialidad> listaEspecialidades = new List<Especialidad>();
        public List<Entidades.Especialidad> ListaEspecialidades {
            get {
                return listaEspecialidades;
            }
            set {
                listaEspecialidades = value;
            }
        }

        List<Entidades.Tratamiento> listaTratamientos = new List<Tratamiento>();
        public List<Entidades.Tratamiento> ListaTratamientos {
            get {
                return listaTratamientos;
            }
            set {
                listaTratamientos = value;
            }
        }

        int profesionalId;
        public int ProfesionalId {
            get {
                return profesionalId;
            }
            set {
                profesionalId = value;
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

        string apellido;
        public string Apellido {
            get {
                return apellido;
            }
            set {
                apellido = value;
            }
        }

        string nroMatricula;
        public string NroMatricula {
            get {
                return nroMatricula;
            }
            set {
                nroMatricula = value;
            }
        }

        string nroTelefono;
        public string NroTelefono {
            get {
                return nroTelefono;
            }
            set {
                nroTelefono = value;
            }
        }

        string dirPersonal;
        public string DirPersonal {
            get {
                return dirPersonal;
            }
            set {
                dirPersonal = value;
            }
        }

        string dirProfesional;
        public string DirProfesional {
            get {
                return dirProfesional;
            }
            set {
                dirProfesional = value;
            }
        }

        string polizaSeguro;
        public string PolizaSeguro {
            get {
                return polizaSeguro;
            }
            set {
                polizaSeguro = value;
            }
        }
    }
}
