using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos {
    public class Profesional {

        public static List<Entidades.Profesional> TablaCompleta() {
            Entidades.Profesional objEntidadesProfesional;
            List<Entidades.Profesional> lista;
            DataTable dt;
            string strSelect;
            SqlDataAdapter da;

            lista = new List<Entidades.Profesional>();
            dt = new DataTable();
            strSelect = "select [iProfesionalId],[cNombre],[cApellido],[cNroMatricula],[cNroTelefono],[cDirPersonal],[cDirProfesional],[cPolizaSeguro] from [dbo].[Profesional] where [bBorrado]=0";
            da = new SqlDataAdapter(strSelect, Conexion.strConexion);

            da.Fill(dt);
            foreach (DataRow fila in dt.Rows) {
                objEntidadesProfesional = new Entidades.Profesional();
                objEntidadesProfesional.ProfesionalId = (int) fila["iProfesionalId"];
                objEntidadesProfesional.Nombre = fila["cNombre"].ToString();
                objEntidadesProfesional.Apellido = fila["cApellido"].ToString();
                objEntidadesProfesional.NroMatricula = fila["cNroMatricula"].ToString();
                objEntidadesProfesional.NroTelefono = fila["cNroTelefono"].ToString();
                objEntidadesProfesional.DirPersonal = fila["cDirPersonal"].ToString();
                objEntidadesProfesional.DirProfesional = fila["cDirProfesional"].ToString();
                objEntidadesProfesional.PolizaSeguro = fila["cPolizaSeguro"].ToString();
                lista.Add(objEntidadesProfesional);
            }

            return lista;
        }

        public static Entidades.Profesional BuscarPorId(int id) {
            Entidades.Profesional objEntidadesProfecional;
            SqlCommand cmd;
            SqlDataReader rd;
            string strSelect;

            objEntidadesProfecional = new Entidades.Profesional();
            strSelect = "select [iProfesionalId],[cNombre],[cApellido],[cNroMatricula],[cNroTelefono],[cDirPersonal],[cDirProfesional],[cPolizaSeguro] from [dbo].[Profesional] where [iProfesionalId]=" + id + " and [bBorrado]=0";
            cmd = new SqlCommand(strSelect, Conexion.Con);

            try {
                Conexion.Con.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read()) {                    
                    objEntidadesProfecional.ProfesionalId = (int) rd["iProfesionalId"];
                    objEntidadesProfecional.Nombre = rd["cNombre"].ToString();
                    objEntidadesProfecional.Apellido = rd["cApellido"].ToString();
                    objEntidadesProfecional.NroMatricula = rd["cNroMatricula"].ToString();
                    objEntidadesProfecional.NroTelefono = rd["cNroTelefono"].ToString();
                    objEntidadesProfecional.DirPersonal = rd["cDirPersonal"].ToString();
                    objEntidadesProfecional.DirProfesional = rd["cDirProfesional"].ToString();
                    objEntidadesProfecional.PolizaSeguro = rd["cPolizaSeguro"].ToString();
                }
                rd.Close();
                Conexion.Con.Close();
            } catch {
                return null;
            }
            objEntidadesProfecional.ListaEspecialidades = Datos.EspecialidadesDeProfesional.TablaEspecialidadesDeProfesional(id);


            return objEntidadesProfecional; 
        }

        public static int Guardar(Entidades.Profesional obj) {
            if (obj.ProfesionalId > 0) {
                Modificar(obj);                
            } else {
                obj.ProfesionalId = GuardarNuevo(obj);
            }

            return obj.ProfesionalId;
        }

        private static int GuardarNuevo(Entidades.Profesional obj) {            
            SqlCommand cmd;            
            SqlDataReader rd;
            string strInsert;
            string strSelect;            
            
            strSelect = "select IDENT_CURRENT ('[dbo].[Profesional]') as Id";            
            strInsert = "insert into [dbo].[Profesional]([cNombre],[cApellido],[cNroMatricula],[cNroTelefono],[cDirPersonal],[cDirProfesional],[cPolizaSeguro]) values ('"+obj.Nombre+"','"+obj.Apellido+"','"+obj.NroMatricula+"','"+obj.NroTelefono+"','"+obj.DirPersonal+"','"+obj.DirProfesional+"','"+obj.PolizaSeguro+"')";
            cmd = new SqlCommand(strInsert, Conexion.Con);

            try {
                Conexion.Con.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(strSelect, Conexion.Con);
                rd = cmd.ExecuteReader();
                rd.Read();
                obj.ProfesionalId = Convert.ToInt32(rd["Id"]);
                rd.Close();
                Conexion.Con.Close();
            } catch {
                //ver
            }
            GuardarEspecialidades(obj);
            
            return obj.ProfesionalId;
        }

        private static void Modificar(Entidades.Profesional obj) {
            SqlCommand cmd;
            string strUpdate;

            strUpdate = "update [dbo].[Profesional] set [cNombre] = '"+obj.Nombre+"',[cApellido]='"+obj.Apellido+"', [cNroMatricula]='"+obj.NroMatricula+"', [cNroTelefono]='"+obj.NroTelefono+"',[cDirPersonal]='"+obj.DirPersonal+"', [cDirProfesional]='"+obj.DirProfesional+"',[cPolizaSeguro]='"+obj.PolizaSeguro+"' where [iProfesionalId] ="+obj.ProfesionalId;
            cmd = new SqlCommand(strUpdate, Conexion.Con);

            try {
                Conexion.Con.Open();
                cmd.ExecuteNonQuery();
                Conexion.Con.Close();
            } catch {
            // Ver catch.
            }
            GuardarEspecialidades(obj);          
        }

        private static void GuardarEspecialidades(Entidades.Profesional objProfesional) {

            List<Entidades.Especialidad> listaEspecialidadesBd = Datos.EspecialidadesDeProfesional.TablaEspecialidadesDeProfesional(objProfesional.ProfesionalId);

            // Toma cada id del gv y lo compara con cada id de la lista y agrega los elementos que no estén en la lista y sí estén en el gv.
            foreach (Entidades.Especialidad especialidadProfesinal in objProfesional.ListaEspecialidades) {                
                bool gvEncontrado = false;
                foreach (Entidades.Especialidad especialidadBd in listaEspecialidadesBd) {                    
                    if (especialidadBd.EspecialidadId== especialidadProfesinal.EspecialidadId) {
                        gvEncontrado = true;
                        break;
                    } else {
                        gvEncontrado = false;
                    }                    
                }
                if (gvEncontrado == false) {
                    Datos.EspecialidadesDeProfesional.GuardarEspecialidadesDeProfesional(objProfesional, especialidadProfesinal);
                }
            }

            // Toma cada id de la listaBd y lo compara con cada id del gv. Quita los elementos de la listaBd que no estén en el gv.
            foreach (Entidades.Especialidad especialidadBd in listaEspecialidadesBd) {
                bool listEncontrado = false;
                foreach (Entidades.Especialidad especialidadProfesional in objProfesional.ListaEspecialidades) {                    
                    if (especialidadBd.EspecialidadId == especialidadProfesional.EspecialidadId) {
                        listEncontrado = true;
                        break;
                    } else {
                        listEncontrado = false;
                    }
                }
                if (listEncontrado == false) {                    
                    Datos.EspecialidadesDeProfesional.Borrar(objProfesional, especialidadBd);                    
                }
            }
        }        
    }
}
