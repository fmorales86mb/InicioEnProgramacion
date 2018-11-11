using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Tratamiento {

        List<Entidades.Paciente> listaPacientes = new List<Paciente>();
        public List<Entidades.Paciente> ListaPacientes {
            get {
                return listaPacientes;
            }
            set {
                listaPacientes = value;
            }        
        }

        List<Entidades.Profesional> listaProfesionales = new List<Profesional>();
        public List<Entidades.Profesional> ListaProfesionales {
            get {
                return listaProfesionales;
            }
            set {
                listaProfesionales = value;
            }
        }       

        int tratamientoId;
        public int TratamientoId {
            get {
                return tratamientoId;
            }
            set {
                tratamientoId = value;
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

        public EstadoTratamiento EstadoTratamiento;

        string horario;
        public string Horario {
            get {
                return horario;
            }
            set {
                horario = value;
            }
        }

        DateTime fechaInicio;
        public DateTime FechaInicio {
            get {
                return fechaInicio;
            }
            set {
                fechaInicio = value;
            }
        }

        DateTime fechaFin;
        public DateTime FechaFin {
            get {
                return fechaFin;
            }
            set {
                fechaFin = value;
            }
        }

        string comentarios;
        public string Comentarios {
            get {
                return comentarios;
            }
            set {
                comentarios = value;
            }
        }

        public override string ToString() {
            return Nombre;
        }
    }
}
