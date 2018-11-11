using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

// Agrego esta biblioteca.
using System.Data.SqlClient;

namespace bibio_fede_2 {
	
	// Hago pública la clase.
	public class BDAutor {

		/// <summary>
		/// Guarda el autor modificándolo o ingresándolo en la BD.
		/// </summary>
		/// <param name="autor"></param>
		public static void Guardar (Autor autor) {
			if (autor.AutorId != 0) {
				BDAutor.Modificar (autor);
			} else {
				BDAutor.Ingresar (autor);
			}
		}

		/// <summary>
		/// Método que borra un autor por id.
		/// </summary>
		/// <param name="autor"></param>
		public static void Borrar (int id) {

			// Creo las variables.
			SqlCommand cmd;
			string delete;

			// Inicializo las varialbes.
			delete = "delete from Autor where iAutorId = " + id;

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (delete, BD.Con);
			cmd.ExecuteNonQuery ();
		}

		/// <summary>
		/// Método que lee un autor por id.
		/// </summary>
		/// <param name="id"></param>
		/// <returns>Devuelve una lista de autores.</returns>
		public static Autor BuscarPorId (int id) {

			// Creo las variables.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Autor au;

			// Inicializo las variables.
			select = "select iAutorid, cNombre, cApellido from Autor where iAutorid =" + id;

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Leo la consulta y la ingreso a la lista.
			if (rd.Read ()) {
				au = new Autor ();
				au.AutorId = Convert.ToInt32 (rd [0]);
				au.Nombre = rd [1].ToString ();
				au.Apellido = rd [2].ToString ();
				rd.Close ();
				return au;
			// Sino devuelvo null.
			} else {
				return null;
			}
		}

		/// <summary>
		/// Lee autores por nombre.
		/// </summary>
		/// <param name="nombre"></param>
		/// <returns>lista de autores, ret</returns>
		public static List<Autor> BuscarPorNombre (string nombre) {

			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Autor> ret;
			Autor au;

			// Inicializo las variables.
			ret = new List<Autor> ();
			select = "select iAutorId, cNombre, cApellido from Autor where cNombre = '" + nombre + "'";

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Mientras haya filas ingresa.
			while (rd.Read ()) {
				// Inicializo el au dentro del while ya que sino se genera una lista con todos elementos iguales al último.
				au = new Autor ();
				au.AutorId = Convert.ToInt32 (rd [0]);
				au.Nombre = rd [1].ToString ();
				au.Apellido = rd [2].ToString ();
				ret.Add (au);
			}
			rd.Close ();
			return ret;
		}

		/// <summary>
		/// Lee autores por apellido.
		/// </summary>
		/// <param name="apellido"></param>
		/// <returns>lista de autores, lista</returns>
		public static List<Autor> BuscarPorApellido (string apellido) {

			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Autor> lista;
			Autor au;

			// Inicializo las variables.
			select = "select iAutorId, cNombre, cApellido from Autor where cApellido = '" + apellido + "'";
			lista = new List<Autor> ();

			// Hago la consulta y la ejecuto.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Mientras haya filas ingresa.
			while (rd.Read ()) {
				au = new Autor ();
				au.AutorId = Convert.ToInt32 (rd [0]);
				au.Nombre = rd [1].ToString ();
				au.Apellido = rd [2].ToString ();
				lista.Add (au);
			}

			// Cierro el reader y devuelvo la lista.
			rd.Close ();
			return lista;
		}

		/// <summary>
		/// Leé autores por el nombre y apellido.
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <returns>Lista de autores.</returns>
		public static List<Autor> BuscarPorNombreYApellido (string nombre, string apellido) {

			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Autor> lista;
			Autor au;

			// Inicializo las variables.
			select = "select iAutorId, cNombre, cApellido from Autor where cNombre = '" + nombre + "' and cApellido = '" + apellido + "'";
			lista = new List<Autor> ();

			// Creo la consulta y la ejecuto.
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			// Mientras haya filas ingresa.
			while (rd.Read ()) {
				au = new Autor ();
				au.AutorId = Convert.ToInt32 (rd [0]);
				au.Nombre = rd [1].ToString ();
				au.Apellido = rd [2].ToString ();
				lista.Add (au);
			}

			// Cierro el reader y devuelvo la lista.
			rd.Close ();
			return lista;
		}

		/// <summary>
		/// Devuelve una lista con todos los autores.
		/// </summary>
		/// <returns></returns>
		public static List<Autor> ListaCompleta () {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Autor autor;
			List<Autor> lista;

			select = "select * from Autor";
			lista = new List<Autor> ();
			
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				autor = new Autor ();				
				autor.AutorId = Convert.ToInt32 (rd [0]);
				autor.Nombre = rd [1].ToString ();
				autor.Apellido = rd [2].ToString ();
				lista.Add (autor);
			}

			rd.Close ();
			return lista;
		}

		public static DataTable Buscar (string texto) {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			string select;
			DataTable tabla;

			select = "select * from Autor where cApellido like '%" + texto + "%' or cNombre like '%" + texto + "%'";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);
			
			return tabla;
		}

		public static DataTable CargarTabla () {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			DataTable tabla;
			string select;

			select = "select * from autor";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);
			
			return tabla;
		}

		// Estos métodos son privadas por que sólo se usan dentro de la clase. El método público es el de Guardar.

		/// <summary>
		/// Ingresa un nuevo autor en la BD.
		/// Nota: id = cero, quiere decir que no existe en la tabla. Los id arrancan desde el 1.
		/// </summary>
		private static void Ingresar (Autor autor) {

			// Creo las variables del método.
			SqlCommand cmd;
			SqlDataReader rd;
			string insert;
			string selectid;

			// Inicializo las variables del método.
			insert = "insert into Autor (cNombre, cApellido) values ('" + autor.Nombre + "', '" + autor.Apellido + "')";
			// Esta consulta me devuelve el último id de la tabla.
			selectid = "select IDENT_CURRENT ('Autor') as id";

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (insert, BD.Con);
			cmd.ExecuteNonQuery ();

			// Busco el id con el que fue ingresado en la tabla.
			cmd = new SqlCommand (selectid, BD.Con);
			rd = cmd.ExecuteReader ();
			rd.Read ();

			// Actualizo el id del autor.
			autor.AutorId = Convert.ToInt32 (rd ["id"]);

			// Luego de usar el reader tengo que cerrarlo.
			rd.Close ();
		}

		/// <summary>
		/// Modifica un autor a partir del id.
		/// </summary>
		/// <param name="autor"></param>
		private static void Modificar (Autor autor) {
			// Creo las variables del métdo
			SqlCommand cmd;
			string update;

			// Inicializo las variables.
			update = "update autor set cnombre = '" + autor.Nombre + "', capellido = '" + autor.Apellido + "' where iautorid =" + autor.AutorId;

			// Creo y ejecuto la consulta.
			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}
	}
}
