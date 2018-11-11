using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebCurso.Datos
{
    public class Libro: Page
    {
        public DataView TraerLibros()
        {
            DataSet ds = new DataSet();

            ds.ReadXml(@"C:\Biblioteca\Libros.xml");
            DataView dv = new DataView(ds.Tables[0]);
            return dv;
        }
    }
}