using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Datos {
    public class EstadoDeTratamiento {
        public static Entidades.EstadoTratamiento BuscarPorId(int id) {
            SqlCommand cmd;
            SqlDataReader rd;
            string strSelect;
            Entidades.EstadoTratamiento objEstadoTratamiento;

            objEstadoTratamiento = new Entidades.EstadoTratamiento();
            strSelect = "select [iEstadoTratamientoId],[cNombre],[cDescripcion] from [dbo].[EstadoTratamiento] where [bBorrado]=0 and [iEstadoTratamientoId]=" + id;
            cmd = new SqlCommand(strSelect, Conexion.Con);

            try {
                Conexion.Con.Open();
                rd = cmd.ExecuteReader();
                rd.Read();
                objEstadoTratamiento.EstadoTratamientoId = (int) rd["iEstadoTratamientoId"];
                objEstadoTratamiento.Nombre = rd["cNombre"].ToString();
                objEstadoTratamiento.Descripcion = rd["cDescripcion"].ToString();
                rd.Close();
                Conexion.Con.Close();
            } catch {
            }

            return objEstadoTratamiento;
        }

        public static List<Entidades.EstadoTratamiento> TablaCompleta() {
            List<Entidades.EstadoTratamiento> lista;
            Entidades.EstadoTratamiento objEstadoTratamiento;
            SqlDataAdapter da;
            DataTable dt;
            string strSelect;

            lista = new List<Entidades.EstadoTratamiento>();
            dt = new DataTable();
            strSelect = "select [iEstadoTratamientoId], [cNombre], [cDescripcion] from [dbo].[EstadoTratamiento] where [bBorrado]=0";
            da = new SqlDataAdapter(strSelect, Conexion.strConexion);

            da.Fill(dt);
            foreach (DataRow fila in dt.Rows) {
                objEstadoTratamiento = new Entidades.EstadoTratamiento();
                objEstadoTratamiento.EstadoTratamientoId = (int) fila[""];
                objEstadoTratamiento.Nombre = fila[""].ToString();
                objEstadoTratamiento.Descripcion = fila[""].ToString();
                lista.Add(objEstadoTratamiento);
            }

            return lista;
        }

        public static int GuardarNuevo(Entidades.EstadoTratamiento obj) {
            int id;
            string strInsert;
            string strSelect;
            SqlCommand cmd;
            SqlDataReader rd;

            id = 0;
            strInsert = "insert into [dbo].[EstadoTratamiento]([cNombre],[cDescripcion]) values ('"+obj.Nombre+"','"+obj.Descripcion+"')";
            strSelect = "select IDENT_CURRENT ('[dbo].[EstadoTratamiento]') as id;";
            cmd = new SqlCommand(strInsert, Conexion.Con);

            try {
                Conexion.Con.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(strSelect, Conexion.Con);
                rd = cmd.ExecuteReader();
                rd.Read();
                id = Convert.ToInt32(rd["id"]);
                rd.Close();
                Conexion.Con.Close();
            } catch {
            }
            
            return id;
        }

    }
}
