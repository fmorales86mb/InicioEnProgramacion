using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class Generico {        

        public static DataTable TablaCompleta(string strSelect) {
            DataTable dt;
            SqlDataAdapter da;

            dt = new DataTable();
            da = new SqlDataAdapter(strSelect, Conexion.strConexion);

            da.Fill(dt);

            return dt;
        }

        public static DataTable BuscarPorId(string strSelect, int id) {
            DataTable dt;
            SqlDataAdapter da;

            dt = new DataTable();
            da = new SqlDataAdapter(strSelect+id, Conexion.strConexion);

            da.Fill(dt);

            return dt;            
        }

        public static int GuardarNuevo(string strSelect, string strInsert) {
            SqlCommand cmd;
            SqlDataReader rd;
            int id = 0;

            cmd = new SqlCommand(strInsert, Conexion.Con);

            try {
                Conexion.Con.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(strSelect, Conexion.Con);
                rd = cmd.ExecuteReader();
                rd.Read();
                id = (int) rd[0];
                rd.Close();
                Conexion.Con.Close();
            } catch {
                // Ver catch.
            }

            return id;
        }
    }
}
