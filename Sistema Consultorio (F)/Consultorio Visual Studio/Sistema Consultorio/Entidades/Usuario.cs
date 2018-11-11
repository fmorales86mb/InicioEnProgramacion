using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Usuario {
        int usuarioId;
        public int UsuarioId {
            get {
                return usuarioId;
            }
            set {
                usuarioId = value;
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

        string login;
        public string Login {
            get {
                return login;
            }
            set {
                login = value;
            }
        }

        string password;
        public string Password {
            get {
                return password;
            }
            set {
                password = value;
            }
        }
    }
}
