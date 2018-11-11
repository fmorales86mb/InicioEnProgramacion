using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos {
    public class Especialidad {

        public static List<Entidades.Especialidad> TablaCompleta() {
            Entidades.Especialidad objEntidadesEspecialidad;
            List<Entidades.Especialidad> lista;
            DataTable dt;
            SqlDataAdapter da;
            string strSelect;

            lista = new List<Entidades.Especialidad>();
            dt = new DataTable();
            strSelect = "select [iEspecialidadId],[cNombre] as Nombre,[cDescripcion] as Descripción from [dbo].[Especialidad] where [bBorrado]=0";
            da = new SqlDataAdapter(strSelect, Conexion.strConexion);

            /*
            El código que se muestra en este ejemplo no abre ni cierra explícitamente el objeto Connection. 
            El método Fill abre de forma implícita el objeto Connection que DataAdapter utiliza cuando encuentra que la conexión 
            no está abierta todavía. Si el método Fill ha abierto la conexión, también la cierra cuando el método Fill deja de utilizarla.
            */

            da.Fill(dt);

            // El foreach repite un bloque de código por cada elemento de una matriz o un objeto (obj 'fila' de la clase 'DataRow') de una colección de objetos (del tipo 'DataRow')
            foreach (DataRow fila in dt.Rows) {
                objEntidadesEspecialidad = new Entidades.Especialidad();
                objEntidadesEspecialidad.EspecialidadId = (int) fila[0];
                objEntidadesEspecialidad.Nombre = fila[1].ToString();
                objEntidadesEspecialidad.Descripcion = fila[2].ToString();
                lista.Add(objEntidadesEspecialidad);
            }
                 
            return lista;
        }

        public static Entidades.Especialidad BuscarPorId(int id) {
            Entidades.Especialidad objEntidadesEspecialidad;
            string strSelect;
            SqlCommand cmd;
            SqlDataReader rd;

            strSelect = "select [iEspecialidadId],[cNombre],[cDescripcion],[bBorrado] from [dbo].[Especialidad] where [bBorrado]=0 and [iEspecialidadId]=" + id;
            cmd = new SqlCommand(strSelect, Conexion.Con);

            Conexion.Con.Open();
            rd = cmd.ExecuteReader();

            if (rd.Read()) {
                objEntidadesEspecialidad = new Entidades.Especialidad();
                objEntidadesEspecialidad.EspecialidadId = (int) rd["iEspecialidadId"];
                objEntidadesEspecialidad.Nombre = rd["cNombre"].ToString();
                objEntidadesEspecialidad.Descripcion = rd["cDescripcion"].ToString();

                rd.Close();
                Conexion.Con.Close();
                return objEntidadesEspecialidad;
            } else {
                rd.Close();
                Conexion.Con.Close();
                return null;
            }
        }

        /// <summary>
        /// Guarda un Objeto Especialidad.
        /// </summary>
        /// <param name="obj">Objeto Especialidad</param>
        /// <returns>true si hay fila afectada</returns>
        public static int GuardarNuevo(Entidades.Especialidad obj) {            
            SqlCommand cmd;
            SqlDataReader rd;
            string strInsert;
            string strSelect;
            int id = 0;

            strSelect = "select IDENT_CURRENT ('[dbo].[Especialidad]') as Id";
            strInsert = "insert into [dbo].[Especialidad] ([cNombre],[cDescripcion]) values ('"+obj.Nombre+"','"+obj.Descripcion+"')";
            cmd = new SqlCommand(strInsert, Conexion.Con);

            try {
                Conexion.Con.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(strSelect, Conexion.Con);
                rd = cmd.ExecuteReader();
                rd.Read();
                id = (int) rd["Id"];
                rd.Close();
                Conexion.Con.Close();
            } catch {
                // Ver catch.
            }

            return id;
        }
    }
}
