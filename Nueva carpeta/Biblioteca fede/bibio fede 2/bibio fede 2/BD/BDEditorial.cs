using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Agrego estas bibliotecas.
using System.Data.SqlClient;
using System.Data;

namespace bibio_fede_2 {

	// Hago pública la clase.
	public class BDEditorial {

		public static void Guardar (Editorial editorial) {
			if (editorial.EditorialId != 0) {
				BDEditorial.Modificar (editorial);
			} else {
				BDEditorial.ingresar (editorial);
			}
		}

		public static void Borrar (int id) {

			// Creo las variables del método.
			SqlCommand cmd;
			string delete;

			// Inicializo las variables.
			delete = "delete from editorial where ieditorialid =" + id;

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (delete, BD.Con);
			cmd.ExecuteNonQuery ();
		}

		public static Editorial BuscarPorId (int id) {

			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Editorial editorial;

			// Inicializo las variables.
			select = "select iEditorialId, cNombre, cDireccion from Editorial where iEditorialId = " + id;
			editorial = new Editorial ();

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Recojo los datos en una lista. Si no hay datos devuelvo null.
			if (rd.Read ()) {
				editorial.EditorialId = Convert.ToInt32 (rd [0]);
				editorial.Nombre = rd [1].ToString ();
				editorial.Dirección = rd [2].ToString ();
				rd.Close ();
				return editorial;
			} else {
				rd.Close ();
				return null;
			}
		}

		public static List<Editorial> BuscarPorNombre (string nombre) {

			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Editorial> lista;
			Editorial editorial;

			// Inicializo las variables.
			select = "select iEditorialId, cNombre, cDireccion from Editorial where cNombre = '" + nombre + "'";
			lista = new List<Editorial> ();

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Leo la consulta y genero la lista.
			while (rd.Read ()) {
				editorial = new Editorial ();
				editorial.EditorialId = Convert.ToInt32 (rd [0]);
				editorial.Nombre = rd [1].ToString ();
				editorial.Dirección = rd [2].ToString ();
				lista.Add (editorial);
			}

			// Cierro el reader y devuelvo la lista.
			rd.Close ();
			return lista;
		}

		public static List<Editorial> BuscarPorDireccion (string direccion) {

			// Creo las varialbes del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Editorial> lista;
			Editorial editorial;

			// Inicializo las varialbes.
			select = "select iEditorialId, cNombre, cDireccion from Editorial where cDireccion = '" + direccion + "'";
			lista = new List<Editorial> ();

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Leo la consulta y lleno la lista.
			while (rd.Read ()) {
				editorial = new Editorial ();
				editorial.EditorialId = Convert.ToInt32 (rd [0]);
				editorial.Nombre = rd [1].ToString ();
				editorial.Dirección = rd [2].ToString ();
				lista.Add (editorial);
			}

			// Cierro el reader y devuelvo la lista.
			rd.Close ();
			return lista;
		}

		public static List<Editorial> BuscarPorNombreYDireccion (string nombre, string direccion) {

			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Editorial> lista;
			Editorial editorial;

			// Inicializo las varialbes.
			select = "select iEditorialId, cNombre, cDireccion from Editorial where cNombre = '" + nombre + "' and cDireccion = '" + direccion + "'";
			lista = new List<Editorial> ();

			// Creo la consulta y la ejecuto.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Leo la consulta y lleno la lista.
			while (rd.Read ()) {
				editorial = new Editorial ();
				editorial.EditorialId = Convert.ToInt32 (rd [0]);
				editorial.Nombre = rd [1].ToString ();	// Código al pedo.
				editorial.Dirección = rd [2].ToString ();	// Código al pedo.
				lista.Add (editorial);
			}

			// Cierro el reader y devuelvo la lista.
			rd.Close ();
			return lista;
		}

		public static List<Editorial> ListaCompleta () {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Editorial editorial;
			List<Editorial> lista;

			select = "select * from Editorial";
			lista = new List<Editorial> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				editorial = new Editorial ();
				editorial.EditorialId = Convert.ToInt32 (rd [0]);
				editorial.Nombre = rd [1].ToString ();
				editorial.Dirección = rd [2].ToString ();
				lista.Add (editorial);
			}

			rd.Close ();
			return lista;
		}

		public static DataTable CargarTabla () {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			DataTable tabla;
			string select;

			select = "select * from Editorial";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);

			return tabla;
		}

		public static DataTable Buscar (string texto) {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			string select;
			DataTable tabla;

			select = "select * from Editorial where cNombre like '%" + texto + "%'";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);

			return tabla;
		}

		private static void ingresar (Editorial editorial) {

			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string insert;
			string selectid;

			// Inicializo las varialbes.
			insert = "insert into Editorial (cNombre, cDireccion) values ('" + editorial.Nombre + "', '" + editorial.Dirección + "')";
			// Esta consulta me devuelve el último id de la tabla.
			selectid = "select IDENT_CURRENT ('Editorial') as id";

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (insert, BD.Con);
			cmd.ExecuteNonQuery ();

			// Busco el nuevo id.
			cmd = new SqlCommand (selectid, BD.Con);
			rd = cmd.ExecuteReader ();
			rd.Read ();

			// Actualizo el id de la editorial.
			editorial.EditorialId = Convert.ToInt32 (rd [0]);

			// Cierro el reader;
			rd.Close ();
		}

		private static void Modificar (Editorial editorial) {

			// Creo las variables del método.
			SqlCommand cmd;
			string update;

			// Inicializo las variables.
			update = "update editorial set cnombre = '" + editorial.Nombre + "', cdireccion = '" + editorial.Dirección + "' where ieditorialid =" + editorial.EditorialId;

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}
	}
}
