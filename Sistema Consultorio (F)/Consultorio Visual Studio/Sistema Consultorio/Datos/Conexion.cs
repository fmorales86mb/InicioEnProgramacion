using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        public static string strConexion = @"Server=MONCHO-PC\SQLEXPRESS; Database=Consultorio1; Integrated Security=True";
        public static SqlConnection Con = new SqlConnection(strConexion);
    }
}
