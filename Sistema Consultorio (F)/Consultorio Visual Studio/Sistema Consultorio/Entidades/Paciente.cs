using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1° Agrego referencia a Entidades.

namespace Entidades
{
    public class Paciente
    {

        List<Entidades.Tratamiento> listaTratamientos;
        List<Entidades.Tratamiento> ListaTratamientos {
            get {
                return listaTratamientos;
            }
            set {
                listaTratamientos = value;
            }
        }

        int pacienteId;
        public int PacienteId{
            get {
                return pacienteId;
            }
            set {
                pacienteId = value;
            }
            
        }

        public ObraSocial ObraSocial;

        public EstadoPaciente EstadoPaciente;

        public TipoPaciente TipoPaciente;

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

        string diagnostico;
        public string Diagnostico {
            get {
                return diagnostico;
            }
            set {
                diagnostico = value;
            }
        }

        string certificadoDiscapacidad;
        public string CertificadoDiscapacidad {
            get {
                return certificadoDiscapacidad;
            }
            set {
                certificadoDiscapacidad = value;
            }
        }

        string medicacion;
        public string Medicacion {
            get {
                return medicacion;
            }
            set {
                medicacion = value;
            }
        }

    }
}
