using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos {
    public class Usuario {
        public static List<Entidades.Usuario> TablaCompleta() {
            List<Entidades.Usuario> lista;
            Entidades.Usuario objEntidadesUsuario;
            DataTable dt;
            SqlDataAdapter da;
            string strSelect;

            lista = new List<Entidades.Usuario>();
            dt = new DataTable();
            strSelect = "SELECT [iUsuarioId],[cNombre],[cApellido],[cLogin],[cPassword] FROM [Consultorio].[dbo].[Usuario] where [bBorrado]=0";
            da = new SqlDataAdapter(strSelect, Conexion.strConexion);

            da.Fill(dt);
            foreach (DataRow fila in dt.Rows) {
                objEntidadesUsuario = new Entidades.Usuario();
                objEntidadesUsuario.UsuarioId = (int) fila["iUsuarioId"];
                objEntidadesUsuario.Nombre = fila["cNombre"].ToString();
                objEntidadesUsuario.Apellido = fila["cApellido"].ToString();
                objEntidadesUsuario.Login = fila["cLogin"].ToString();
                objEntidadesUsuario.Password = fila["cPassword"].ToString();
                lista.Add(objEntidadesUsuario);
            }

            return lista;
        }
    }
}
