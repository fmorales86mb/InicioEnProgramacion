using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace bibio_fede_2 {
	public class BDBiblioteca {

		public static void Guardar (Biblioteca biblio) {
			if (biblio.BibliotecaId == 0) {
				Ingresar (biblio);
			} else {
				Modificar (biblio);
			}
		}

		public static void Borrar (int id) {
			SqlCommand cmd;
			string delete;

			delete = "delete from Biblioteca where iBibliotecaId =" + id;

			cmd = new SqlCommand (delete, BD.Con);
			cmd.ExecuteNonQuery ();
		}

		public static Biblioteca BuscarPorId (int id) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Biblioteca biblio = null;

			select = "select * from Biblioteca where iBibliotecaId =" + id;

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			if (rd.Read ()) {
				biblio = new Biblioteca ();
				biblio.BibliotecaId = id;
				biblio.Nombre = rd [1].ToString ();
				biblio.Descripcion = rd [2].ToString ();
				rd.Close ();
			}

			return biblio;
		}

		public static List<Biblioteca> BuscarPorNombre (Biblioteca biblioteca) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Biblioteca> lista;
			Biblioteca biblio;

			select = "select * from Biblioteca where cNombre = '" + biblioteca.Nombre + "'";
			lista = new List<Biblioteca> ();			

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				biblio = new Biblioteca ();
				biblio.BibliotecaId = Convert.ToInt32 (rd [0]);
				biblio.Nombre = rd [1].ToString ();
				biblio.Descripcion = rd [2].ToString ();
				lista.Add (biblio);
			}

			rd.Close ();
			return lista;
		}

		public static List<Biblioteca> BuscarPorDescripcion (string palabra) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Biblioteca> lista;
			Biblioteca biblio;

			select = "select * from Biblioteca where cDescripcion like '%" + palabra + "%'";
			lista = new List<Biblioteca> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				biblio = new Biblioteca ();
				biblio.BibliotecaId = Convert.ToInt32 (rd [0]);
				biblio.Nombre = rd [1].ToString ();
				biblio.Descripcion = rd [2].ToString ();
				lista.Add (biblio);
			}

			rd.Close ();
			return lista;
		}

		public static DataTable CargarTabla () {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			DataTable tabla;
			string select;

			select = "select * from Biblioteca";
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

			select = "select* from Biblioteca where cNombre like '%" + texto + "%' or cDescripcion like '%" + texto + "%'";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);

			return tabla;
		}

		private static void Ingresar (Biblioteca biblio) {
			SqlCommand cmd;
			SqlDataReader rd;
			string insert;
			string select;

			insert = "insert into Biblioteca (cNombre, cDescripcion) values ('" + biblio.Nombre + "', '" + biblio.Descripcion + "')";
			select = "select IDENT_CURRENT ('Biblioteca')";

			cmd = new SqlCommand (insert, BD.Con);
			cmd.ExecuteNonQuery ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();
			rd.Read ();
			biblio.BibliotecaId = Convert.ToInt32 (rd [0]);
			rd.Close ();
		}

		private static void Modificar (Biblioteca biblio) {
			SqlCommand cmd;
			string update;

			update = "update Biblioteca set cNombre ='" + biblio.Nombre + "', cDescripcion = '" + biblio.Descripcion + "' where iBibliotecaId =" + biblio.BibliotecaId;

			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}
	}
}
