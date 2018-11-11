using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agrego esta biblioteca.
using System.Data.SqlClient;
using System.Data;

namespace bibio_fede_2 {

	// Hago pública la clase.
	public class BDTipoLibro {

		// Creo los métodos 
		public static void Guardar (TipoLibro tipo) {
			if (tipo.TipoLibroId != 0) {
				Modificar (tipo);
			} else {
				Ingresar (tipo);
			}
		}

		public static void Borrar (int id) {
			// Creo las variables del método.
			SqlCommand cmd;
			string delete;

			// inicializo las variables.
			delete = "delete from TipoLibro where iTipoLibroId =" + id;

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (delete, BD.Con);
			cmd.ExecuteNonQuery ();
		}

		public static TipoLibro BuscarPorId (int id) {

			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			TipoLibro tipo;

			// Inicializo las variables.
			select = "select * from TipoLibro where iTipoLibroId =" + id;
			tipo = new TipoLibro ();

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Leo y lleno la lista con lo devuelto.
			if (rd.Read ()) {
				tipo.TipoLibroId = Convert.ToInt32 (rd [0]);
				tipo.Nombre = rd [1].ToString ();
				tipo.Descripcion = rd [2].ToString ();
				rd.Close ();
				return tipo;
			// Sino devuelvo null;
			} else {
				return null;
			}
		}

		public static List<TipoLibro> BuscarPorNombre (string nombre) {

			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<TipoLibro> lista;
			TipoLibro tipo;

			// Inicializo las variables del método.
			select = "select * from TipoLibro where cNombre = '" + nombre + "'";
			lista = new List<TipoLibro> ();

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Leo y lleno la lista con el resultado.
			while (rd.Read ()) {
				tipo = new TipoLibro ();
				tipo.TipoLibroId = Convert.ToInt32 (rd [0]);
				tipo.Nombre = rd [1].ToString ();
				tipo.Descripcion = rd [2].ToString ();
				lista.Add (tipo);
			}

			// Cierro el reader y devuelvo la lista.
			rd.Close ();
			return lista;
		}

		public static List<TipoLibro> BuscarPorDescripcion (string palabra) {
			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<TipoLibro> lista;
			TipoLibro tipo;

			// Inicializo las variables.
			select = "select * from TipoLibro where cDescripcion like '%"+palabra+"%'";
			lista = new List<TipoLibro> ();

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Leo y lleno la lista con el resultado.
			while (rd.Read ()) {
				tipo = new TipoLibro ();
				tipo.TipoLibroId = Convert.ToInt32 (rd [0]);
				tipo.Nombre = rd [1].ToString ();
				tipo.Descripcion = rd [2].ToString ();
				lista.Add (tipo);
			}

			// Cierro el reader y devuelvo la lista.
			rd.Close ();
			return lista;
		}

		public static List<TipoLibro> ListaCompleta () {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			TipoLibro tipo;
			List<TipoLibro> lista;

			select = "select * from TipoLibro";
			lista = new List<TipoLibro> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				tipo = new TipoLibro ();
				tipo.TipoLibroId = Convert.ToInt32 (rd [0]);
				tipo.Nombre = rd [1].ToString ();
				tipo.Descripcion = rd [2].ToString ();
				lista.Add (tipo);
			}

			rd.Close ();
			return lista;
		}

		public static DataTable CargarTabla () {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			DataTable tabla;
			string select;

			select = "select * from TipoLibro";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);

			return tabla;
		}

		private static void Ingresar (TipoLibro tipo) {
			
			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string insert;
			string selectid;

			// Inicializo las variables.
			insert = "insert into tipolibro (cnombre, cdescripcion) values ('" + tipo.Nombre + "', '" + tipo.Descripcion + "')";
			selectid = "select IDENT_CURRENT ('TipoLibro')";

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (insert, BD.Con);
			cmd.ExecuteNonQuery ();

			// Consulto el último tipolibro ingresado y lo leo.
			cmd = new SqlCommand (selectid, BD.Con);
			rd = cmd.ExecuteReader ();
			rd.Read ();

			// Completo mi objeto tipolibro con los datos leidos.
			tipo.TipoLibroId = Convert.ToInt32 (rd[0]);

			// Cierro el reader.
			rd.Close ();
		}

		private static void Modificar (TipoLibro tipo) {
			
			// Creo las variables del método.
			SqlCommand cmd;
			string update;

			// Inicializo las variables.
			update = "update TipoLibro set cNombre = '" + tipo.Nombre + "', cDescripcion = '" + tipo.Descripcion + "' where iTipoLibroId =" + tipo.TipoLibroId;

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}
	}
}
