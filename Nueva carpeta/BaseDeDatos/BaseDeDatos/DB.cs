using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/// <summary>
/// Tarea para el hogar:
/// - Implementar la funcion Desconectar ()
/// - Implementar la funcion LeerAutorPorNombreYApellido (string nombre, string apellido) tiene que devolver un autor
/// - Modificar la funcion GuardarAutor para que despues de insertar obtenga el id del registro que acaba de insertar.
/// - Implementar la funcion Actualizar (Autor au) recibe un autor y actualiza en la DB los valores de nombre y apellido
/// 
/// 
/// </summary>

namespace BaseDeDatos {
    class DB {
        private static SqlConnection conn;

        public static bool Conectar () {
            conn = new SqlConnection ("Data Source=PC-CASA\\SQLEXPRESS;Initial Catalog=db_prueba2;Integrated Security=True;Pooling=False");

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open) {
                return true;

            } else {
                return false;
            }
        }

        public static bool GuardarAutor (Autor au) {
            SqlCommand cmd;

            cmd = new SqlCommand("INSERT INTO Autor (cNombre, cApellido) VALUES ('" + au.Nombre + "', '" + au.Apellido + "')", conn);
            cmd.ExecuteNonQuery();

            au.Id = 222;

            return true;
        }

        public static void BorrarAutorPorNombre (string nombre){
            SqlCommand cmd;

            cmd = new SqlCommand("Delete from Autor where cNombre = '" + nombre + "'", conn);
            cmd.ExecuteNonQuery();
        }
        
        public static Autor LeerAutorPorId (int id) {
            SqlCommand cmd;
            SqlDataReader rd;
            Autor au = null;

            cmd = new SqlCommand("select cNombre, cApellido from Autor where iAutorId = " + id, conn);
            rd = cmd.ExecuteReader();

            // Si devolvio datos
            if (rd.Read ()) {
                au = new Autor();
                au.Nombre   = rd["cNombre"].ToString ();
                au.Apellido = rd["cApellido"].ToString ();
                au.Id       = id;
            }

            return au;
        }
    }
}
