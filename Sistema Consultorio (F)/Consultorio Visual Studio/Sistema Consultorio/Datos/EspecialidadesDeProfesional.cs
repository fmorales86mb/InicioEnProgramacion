using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos {
    public class EspecialidadesDeProfesional {
        public static List<Entidades.Especialidad> TablaEspecialidadesDeProfesional(int idProfesional) {
            List<Entidades.Especialidad> lista;
            SqlDataAdapter da;
            DataTable dt;
            string strSelect;

            lista = new List<Entidades.Especialidad>();
            dt = new DataTable();
            strSelect = "select [iEspecialidadId] from [dbo].[EspecialidadesDeProfesional] where [iProfesionalId]=" + idProfesional;
            da = new SqlDataAdapter(strSelect, Conexion.strConexion);
            
            da.Fill(dt);
            foreach (DataRow fila in dt.Rows) {
                lista.Add(Datos.Especialidad.BuscarPorId((int) fila["iEspecialidadId"]));
            }

            return lista;
        }

        public static bool GuardarEspecialidadesDeProfesional(Entidades.Profesional objProfesional, Entidades.Especialidad objEspecialidad) {
            bool guardado;
            SqlCommand cmd;
            string strInsert;

            strInsert = "insert into [dbo].[EspecialidadesDeProfesional]([iProfesionalId],[iEspecialidadId])values(" + objProfesional.ProfesionalId + "," + objEspecialidad.EspecialidadId + ")";
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

        public static void Borrar(Entidades.Profesional objProfesional, Entidades.Especialidad objEspecialidad) {
            SqlCommand cmd;
            string strDelete;

            strDelete = "delete from [dbo].[EspecialidadesDeProfesional] where [iProfesionalId]=" + objProfesional.ProfesionalId + " and [iEspecialidadId]=" + objEspecialidad.EspecialidadId;
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
