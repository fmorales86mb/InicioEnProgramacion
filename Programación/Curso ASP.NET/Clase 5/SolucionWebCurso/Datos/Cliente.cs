using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cliente
    {
        Entidades.dcClienteDataContext db = new Entidades.dcClienteDataContext();

        public object TraerTodos()
        {
            var clientes = from c in db.Customer
                           select c;
            return clientes;

        }

        //Laboratorio traer x pais caso 2
        // Traigo clientes de un pais pasado por parametro
        public object TraerxPais(string pPais)
        {
            var clientes = from c in db.Customer
                           where c.Country.Equals(pPais)
                           select c;
            return clientes;
        }

        //Laboratorio 2
        //Traigo distintos paises x Linq
        public object TraerPaises()
        {
            var clientes = (from c in db.Customer
                            select new { c.Country }).Distinct();
            return clientes;
        }

        public void Agregar(Entidades.Customer pCliente)
        {
            // defino una variable con el nombre del SP
            string strProcedure = "p_alta_cliente";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comAgregar = new SqlCommand(strProcedure, objConexion);

            // le digo que cuando ejecute el comando interpre el primer parametro com un SP
            comAgregar.CommandType = System.Data.CommandType.StoredProcedure;

            comAgregar.Parameters.AddWithValue("@idCliente", pCliente.CustomerID);
            comAgregar.Parameters.AddWithValue("@Cliente", pCliente.CompanyName);
            comAgregar.Parameters.AddWithValue("@Contacto", pCliente.ContactName);
            comAgregar.Parameters.AddWithValue("@Ciudad", pCliente.City);
            comAgregar.Parameters.AddWithValue("@Pais", pCliente.Country);
            objConexion.Open();
            comAgregar.ExecuteNonQuery();
            objConexion.Close();

        }
    }
}
