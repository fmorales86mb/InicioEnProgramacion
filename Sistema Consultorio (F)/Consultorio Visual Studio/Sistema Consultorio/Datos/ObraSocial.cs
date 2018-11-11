using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos {
    public class ObraSocial {

        public static List<Entidades.ObraSocial> TablaCompleta() {
            List<Entidades.ObraSocial> lista;
            Entidades.ObraSocial objEntidadesObraSocial;
            DataTable dt;
            SqlDataAdapter da;
            string strSelect;

            lista = new List<Entidades.ObraSocial>();
            dt = new DataTable();
            strSelect = "SELECT [iObraSocialId],[cNombre],[cDireccion],[cTelefono],[cInformacionAdicional],[cCuit] FROM [Consultorio].[dbo].[ObraSocial] where [bBorrado]=0";
            da = new SqlDataAdapter(strSelect, Conexion.strConexion);

            da.Fill(dt);
            foreach (DataRow fila in dt.Rows) {
                objEntidadesObraSocial = new Entidades.ObraSocial();
                objEntidadesObraSocial.ObraSocialId = (int) fila["iObraSocialId"];
                objEntidadesObraSocial.Nombre = fila["cNombre"].ToString();
                objEntidadesObraSocial.Direccion = fila["cDireccion"].ToString();
                objEntidadesObraSocial.Telefono = fila["cTelefono"].ToString();
                objEntidadesObraSocial.InformacionAdicional = fila["cInformacionAdicional"].ToString();
                objEntidadesObraSocial.Cuit = fila["cCuit"].ToString();
                lista.Add(objEntidadesObraSocial);
            }

            return lista;
        }

        public static Entidades.ObraSocial BuscarPorId(int id) {
            SqlCommand cmd;
            SqlDataReader rd;
            string strSelect;
            Entidades.ObraSocial objObraSocial;

            strSelect = "select [iObraSocialId],[cNombre],[cDireccion],[cTelefono],[cInformacionAdicional],[cCuit] from [dbo].[ObraSocial] where [bBorrado]=0 and [iObraSocialId]=" + id;
            objObraSocial = new Entidades.ObraSocial();
            cmd = new SqlCommand(strSelect, Conexion.Con);

            Conexion.Con.Open();
            rd = cmd.ExecuteReader();
            rd.Read();
            objObraSocial.ObraSocialId = (int) rd["iObraSocialId"];
            objObraSocial.Nombre = rd["cNombre"].ToString();
            objObraSocial.Direccion = rd["cDireccion"].ToString();
            objObraSocial.Telefono = rd["cTelefono"].ToString();
            objObraSocial.InformacionAdicional = rd["cInformacionAdicional"].ToString();
            objObraSocial.Cuit = rd["cCuit"].ToString();
            rd.Close();
            Conexion.Con.Close();

            return objObraSocial;
        }
    }
}
