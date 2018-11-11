using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Datos {
    public class Tratamiento {

        public static List<Entidades.Tratamiento> TablaCompleta() {
            SqlDataAdapter da;
            DataTable tb;
            string strSelect;
            List<Entidades.Tratamiento> lista;
            Entidades.Tratamiento objTratamiento;

            strSelect = "select [iTratamientoId],[cNombre],[iEstadoTratamientoId],[cHorario],[dFechaInicio],[dFechaFin],[cComentarios] from [dbo].[Tratamiento] where [bBorrado] = 0";
            lista = new List<Entidades.Tratamiento>();
            tb = new DataTable();
            da = new SqlDataAdapter(strSelect, Conexion.strConexion);

            da.Fill(tb);
            foreach (DataRow fila in tb.Rows) {
                objTratamiento = new Entidades.Tratamiento();
                objTratamiento.TratamientoId = (int) fila["iTratamientoId"];
                objTratamiento.Nombre = fila["cNombre"].ToString();
                objTratamiento.EstadoTratamiento = Datos.EstadoDeTratamiento.BuscarPorId((int) fila["iEstadoTratamientoId"]);
                objTratamiento.Horario = fila["cHorario"].ToString();
                objTratamiento.FechaInicio = (DateTime) fila["dFechaInicio"];
                objTratamiento.FechaFin = (DateTime) fila["dFechaFin"];
                objTratamiento.Comentarios = fila["cComentarios"].ToString();
                lista.Add(objTratamiento);
            }

            return lista;
        }

        public static Entidades.Tratamiento BuscarPorId(int id) {
            SqlCommand cmd;
            SqlDataReader rd;
            string strSelect;
            Entidades.Tratamiento objTratamiento;

            objTratamiento = new Entidades.Tratamiento();
            strSelect = "select [iTratamientoId],[cNombre],[iEstadoTratamientoId],[cHorario],[dFechaInicio],[dFechaFin],[cComentarios] from [dbo].[Tratamiento] where [bBorrado] = 0 and [iTratamientoId]=" + id;
            cmd = new SqlCommand(strSelect, Conexion.Con);

            try {
                Conexion.Con.Open();
                rd = cmd.ExecuteReader();
                rd.Read();
                objTratamiento.TratamientoId = (int) rd["iTratamientoId"];
                objTratamiento.Nombre = rd["cNombre"].ToString();
                objTratamiento.EstadoTratamiento = Datos.EstadoDeTratamiento.BuscarPorId((int) rd["iEstadoTratamientoId"]);
                objTratamiento.Horario = rd["cHorario"].ToString();
                objTratamiento.FechaInicio = (DateTime) rd["dFechaInicio"];
                objTratamiento.FechaFin = (DateTime) rd["dFechaFin"];
                objTratamiento.Comentarios = rd["cComentarios"].ToString();
                rd.Close();
                Conexion.Con.Close();
            } catch {
            }

            return objTratamiento;
        }

        public static int Guardar(Entidades.Tratamiento obj) {
            if (obj.TratamientoId > 0) {
                Modificar(obj);                
            } else {
                obj.TratamientoId = GuardarNuevo(obj);
            }

            return obj.TratamientoId;
        }

        private static int GuardarNuevo(Entidades.Tratamiento obj) {            
            SqlCommand cmd;            
            SqlDataReader rd;
            string strInsert;
            string strSelect;

            strSelect = "select IDENT_CURRENT ('[dbo].[Tratamiento]') as Id";
            strInsert = "insert into [dbo].[Tratamiento] ([cNombre],[iEstadoTratamientoId],[cHorario],[dFechaInicio],[dFechaFin],[cComentarios]) values ('" + obj.Nombre + "'," + obj.EstadoTratamiento.EstadoTratamientoId + ",'" + obj.Horario + "','" + obj.FechaInicio + "','" + obj.FechaFin + "', '" + obj.Comentarios + "')";
            cmd = new SqlCommand(strInsert, Conexion.Con);

            try {
                Conexion.Con.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(strSelect, Conexion.Con);
                rd = cmd.ExecuteReader();
                rd.Read();
                obj.TratamientoId = Convert.ToInt32(rd["Id"]);
                rd.Close();
                Conexion.Con.Close();
            } catch {
                //ver
            }
            GuardarProfesionales(obj);
            
            return obj.TratamientoId;
        }

        private static void Modificar(Entidades.Tratamiento obj) {
            SqlCommand cmd;
            string strUpdate;

            strUpdate = "update [dbo].[Tratamiento] set [cNombre]='" + obj.Nombre + "', [iEstadoTratamientoId]=" + obj.EstadoTratamiento.EstadoTratamientoId + ", [cHorario]='" + obj.Horario + "', [dFechaInicio]='" + obj.FechaInicio + "', [dFechaFin]='" + obj.FechaFin + "', [cComentarios]='" + obj.Comentarios + "' where [iTratamientoId]=" + obj.TratamientoId;
            cmd = new SqlCommand(strUpdate, Conexion.Con);

            try {
                Conexion.Con.Open();
                cmd.ExecuteNonQuery();
                Conexion.Con.Close();
            } catch {
            // Ver catch.
            }
            GuardarProfesionales(obj);          
        }

        private static void GuardarProfesionales(Entidades.Tratamiento objTratamiento) {

            List<Entidades.Profesional> listaProfesionalesBd = Datos.ProfesionalesDeTratamiento.TablaProfesionalesDeTratamiento(objTratamiento.TratamientoId);

            // Toma cada id del gv y lo compara con cada id de la lista y agrega los elementos que no estén en la lista y sí estén en el gv.
            foreach (Entidades.Profesional profesionalDeTratamiento in objTratamiento.ListaProfesionales) {                
                bool gvEncontrado = false;
                foreach (Entidades.Profesional profesionalBd in listaProfesionalesBd) {                    
                    if (profesionalBd.ProfesionalId == profesionalDeTratamiento.ProfesionalId) {
                        gvEncontrado = true;
                        break;
                    } else {
                        gvEncontrado = false;
                    }                    
                }
                if (gvEncontrado == false) {                                        
                    Datos.ProfesionalesDeTratamiento.GuardarProfesionalesDeTratamiento(objTratamiento, profesionalDeTratamiento);
                }
            }

            // Toma cada id de la listaBd y lo compara con cada id del gv. Quita los elementos de la listaBd que no estén en el gv.
            foreach (Entidades.Profesional profesionalBd in listaProfesionalesBd) {
                bool listEncontrado = false;
                foreach (Entidades.Profesional profesionalDeTratamiento in objTratamiento.ListaProfesionales) {                    
                    if (profesionalBd.ProfesionalId == profesionalDeTratamiento.ProfesionalId) {
                        listEncontrado = true;
                        break;
                    } else {
                        listEncontrado = false;
                    }
                }
                if (listEncontrado == false) {                                        
                    Datos.ProfesionalesDeTratamiento.Borrar(profesionalBd, objTratamiento);
                }
            }
        }        
    }
}
