using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agrego biblioteca.
using System.Data.SqlClient;
using System.Data;

namespace bibio_fede_2 {
	// Hago pública la clase.
	public class BDIdioma {
		// Creo los métodos de la clase.
		public static void Guardar (Idioma idioma) {
			if (idioma.idiomaId != 0) {
				Modificar (idioma);
			} else {
				Ingresar (idioma);
			}
		}

		public static void Borrar (int id) {
			// Creo las variables del  método.
			SqlCommand cmd;
			string delete;

			// Inicializo las variables.
			delete = "delete from Idioma where iIdiomaId =" + id;

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (delete, BD.Con);
			cmd.ExecuteNonQuery ();
		}

		public static Idioma BuscarPorId (int id) {
			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Idioma idioma;

			// Inicializo las variables.
			select = "select * from Idioma where iIdiomaId =" + id;
			idioma = new Idioma ();

			// Creo la consulta y la ejecuto.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Leo la consulta y creo un objeto Idioma.
			if (rd.Read ()) {
				idioma.idiomaId = Convert.ToInt32 (rd [0]);
				idioma.Nombre = rd [1].ToString ();
				rd.Close ();
				return idioma;
			// Sino devuelvo null;
			} else {
				return null;
			}
		}

		public static List<Idioma> BuscarPorNombre (Idioma idi) {
			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Idioma idioma;
			List<Idioma> lista;

			// Inicializo las variables.
			select = "select * from Idioma where cNombre = '" + idi.Nombre + "'";
			lista = new List<Idioma> ();

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Leo y lleno la lista de objetos.
			while (rd.Read ()) {
				idioma = new Idioma ();
				idioma.idiomaId = Convert.ToInt32 (rd [0]);
				idioma.Nombre = rd [1].ToString ();
				lista.Add (idioma);
			}

			// Cierro el reader y devuelvo la lista.
			rd.Close ();
			return lista;
		}

		/// <summary>
		/// Obtiene la lista completa de elementos "idioma" de la BD.
		/// </summary>
		/// <returns></returns>
		public static List<Idioma> ListaCompleta () {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Idioma idioma;
			List<Idioma> lista;

			select = "select * from Idioma";
			lista = new List<Idioma> ();	

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				// Inicializo el objeto idioma dentro del while porque sino se van pisando las cargas y quedan todas iguales al último idioma cargado.
				idioma = new Idioma ();
				idioma.idiomaId = Convert.ToInt32 (rd [0]);
				idioma.Nombre = rd [1].ToString ();
				lista.Add (idioma);
			}

			rd.Close ();
			return lista;
		}

		public static DataTable CargarTabla () {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			DataTable tabla;
			string select;

			select = "select * from Idioma";
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

			select = "select * from Idioma where cNombre like '%" + texto + "%'";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);

			return tabla;
		}
		
		private static void Ingresar (Idioma idioma) {
			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string insert;
			string select;
			
			// Inicializo las varialbes.
			insert = "insert into Idioma (cNombre) values ('" + idioma.Nombre + "')";
			select = "select IDENT_CURRENT ('Idioma')";

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (insert, BD.Con);
			cmd.ExecuteNonQuery ();

			// Busco el id con el que fue ingresado.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();
			rd.Read ();

			// Actualizo el id del objeto ingresado y cierro el reader.
			idioma.idiomaId = Convert.ToInt32 (rd [0]);
			rd.Close ();
		}

		private static void Modificar (Idioma idioma) {
			// Creo las variables del método.
			SqlCommand cmd;
			string update;

			// Inicializo las variables.
			update = "update Idioma set cNombre ='" + idioma.Nombre + "' where iIdiomaId =" + idioma.idiomaId;

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}
	}
}
