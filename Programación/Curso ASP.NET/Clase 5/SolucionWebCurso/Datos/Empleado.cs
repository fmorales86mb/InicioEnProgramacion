using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Empleado
    {
        // metodos de acceso y manipulacion de datos

        /// <summary>
        /// Descripcion: Devuelve un DataTable con algunos campos de Employees
        /// Autor : Curso ASP NET
        /// Fecha : 26/10/2016
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select Lastname as Apellido,FirstName as Nombre,Title as Titulo,";
            strSQL += " City as Ciudad,Country as Pais from Employees";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Conexion.strConexion);
            da.Fill(dt);
            return dt;

        }

        //Laboratorio DATAVIEW
        public DataTable TraerPaises()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select distinct Country as Pais from Employees ";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Conexion.strConexion);
            da.Fill(dt);
            return dt;
        } 
    }
}
