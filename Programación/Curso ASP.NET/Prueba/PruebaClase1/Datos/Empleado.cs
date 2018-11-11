using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Empleado
    {
        public DataTable TraerTodos(){
            DataTable dt;
            string strSql;
            SqlDataAdapter da;

            dt = new DataTable();
            strSql = "select Employees.lastname as Apellido, firstname as Nombre, title as Título, city as Ciudad, Country as País from employees";
            da = new SqlDataAdapter(strSql, Conexion.strConexion);
            
            da.Fill(dt);
            return dt;
        }

        // Este método lo uso en el caso en el que filtramos con el data view (memoria).
        public DataTable TraerPaises() {
            DataTable dt;
            string strSql;
            SqlDataAdapter da;

            dt = new DataTable();
            // Me trae los países distintos que hay en la lista de empleados.
            strSql = "select distinct country as País from Employees";
            da = new SqlDataAdapter(strSql, Conexion.strConexion);

            da.Fill(dt);
            return dt;
        }
    }
}
