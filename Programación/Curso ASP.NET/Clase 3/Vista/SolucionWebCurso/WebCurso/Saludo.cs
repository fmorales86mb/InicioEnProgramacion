using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCurso
{
    public class Saludo
    {
        public string Saludar (string pNombre, string pIdioma)
        {
            string strRespuesta = "Inicializo";
            string strSaludo;

            switch (pIdioma)
            { 
                case "Español":
                    strSaludo = "Hola";
                    break;
                case "Ingles":
                    strSaludo = "Hello";
                    break;
                case "Frances":
                    strSaludo = "Bon Jour";
                    break;
                default:
                    strSaludo = "Hola";
                    break;
            }

            strRespuesta = strSaludo + " " + pNombre;
            return strRespuesta;

        }
    }
}