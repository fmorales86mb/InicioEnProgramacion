using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCurso
{
    public class Usuario
    {
        // propiedades
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string idioma;

        public string Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }
    }
}