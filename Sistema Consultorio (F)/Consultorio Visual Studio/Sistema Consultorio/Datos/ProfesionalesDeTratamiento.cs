using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class ProfesionalesDeTratamiento {
        public static List<Entidades.Profesional> TablaProfesionalesDeTratamiento(int idTratamiento) {
            List<Entidades.Profesional> lista;
            SqlDataAdapter da;
            DataTable dt;
            string strSelect;

            lista = new List<Entidades.Profesional>();
            dt = new DataTable();
            strSelect = "select [iProfesionalId] from [dbo].[ProfesionalesDeTratamiento] where [iTratamientoId]=" + idTratamiento;
            da = new SqlDataAdapter(strSelect, Conexion.strConexion);

            da.Fill(dt);
            foreach (DataRow fila in dt.Rows) {
                lista.Add(Datos.Profesional.BuscarPorId((int) fila["iProfesionalId"]));
            }

            return lista;
        }

        public static bool GuardarProfesionalesDeTratamiento(Entidades.Tratamiento objTratamiento, Entidades.Profesional objProfesional) {
            bool guardado;
            SqlCommand cmd;
            string strInsert;

            strInsert = "insert into [dbo].[ProfesionalesDeTratamiento]([iProfesionalId],[iTratamientoId])values(" + objProfesional.ProfesionalId + "," + objTratamiento.TratamientoId + ")";
            cmd = new SqlCommand(strInsert, Conexion.Con);

            guardado = false;
            try {
                Conexion.Con.Open();
                cmd.ExecuteNonQuery();
                Conexion.Con.Close();
                guardado = true;
            } catch {
                guardado = false;
            }
            return guardado;
        }

        public static void Borrar(Entidades.Profesional objProfesional, Entidades.Tratamiento objTratamiento) {
            SqlCommand cmd;
            string strDelete;

            strDelete = "delete from [dbo].[ProfesionalesDeTratamiento] where [iTratamientoId]=" + objTratamiento.TratamientoId + " and [iProfesionalId]=" + objProfesional.ProfesionalId;
            cmd = new SqlCommand(strDelete, Conexion.Con);

            try {
                Conexion.Con.Open();
                cmd.ExecuteNonQuery();
                Conexion.Con.Close();
            } catch {
                // Ver catch.
            }
        }
    }
}
