using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace bibio_fede_2 {
	public class BDLibro {
		public static void Guardar (Libro lib) {
			if (lib.LibroId == 0) {
				Ingresar (lib);
			} else {
				Modificar (lib);
			}
		}

		/// <summary>
		/// Borrado lógico.
		/// </summary>
		/// <param name="id"></param>
		public static void Borrar (int id) {
			SqlCommand cmd;
			string update;

			update = "update Libro set bActivo = 0 where iLibroId =" + id;

			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}

		public static Libro BuscarPorId (int id) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Libro libro = null;
			
			select = "select * from Libro where iLibroId=" + id + " and bActivo = 1";
			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			if (rd.Read ()) {
				libro = new Libro ();
				libro.LibroId = Convert.ToInt32 (rd [0]);
				libro.Editorial = BDEditorial.BuscarPorId (Convert.ToInt32 (rd [1]));
				libro.Autor = BDAutor.BuscarPorId (Convert.ToInt32 (rd [2]));
				libro.Idioma = BDIdioma.BuscarPorId (Convert.ToInt32 (rd [3]));
				libro.Tipo = BDTipoLibro.BuscarPorId (Convert.ToInt32 (rd [4]));
				libro.DescripcionCorta = rd [5].ToString ();
				libro.DescripcionLarga = rd [6].ToString ();
				libro.AnioEdicion = Convert.ToInt32 (rd [7]);
				libro.Activo = true;
				libro.Titulo = rd [9].ToString ();
			}

			rd.Close ();
			return libro;
		}

		public static List<Libro> BuscarPorEditorial (Editorial ed) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Libro> lista;
			Libro libro;

			select = "select * from Libro where iEditorialId=" + ed.EditorialId + " and bActivo = 1";
			lista = new List<Libro> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				libro = new Libro ();
				libro.LibroId = Convert.ToInt32 (rd [0]);
				libro.Editorial = BDEditorial.BuscarPorId (Convert.ToInt32 (rd [1]));
				libro.Autor = BDAutor.BuscarPorId (Convert.ToInt32 (rd [2]));
				libro.Idioma = BDIdioma.BuscarPorId (Convert.ToInt32 (rd [3]));
				libro.Tipo = BDTipoLibro.BuscarPorId (Convert.ToInt32 (rd [4]));
				libro.DescripcionCorta = rd [5].ToString ();
				libro.DescripcionLarga = rd [6].ToString ();
				libro.AnioEdicion = Convert.ToInt32 (rd [7]);
				libro.Activo = true;
				libro.Titulo = rd [9].ToString ();
				lista.Add (libro);
			}

			rd.Close ();
			return lista;
		}

		public static List<Libro> BuscarPorAutor (Autor au) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Libro> lista;
			Libro libro;

			select = "select * from Libro where iAutorId=" + au.AutorId + " and bActivo = 1";
			lista = new List<Libro> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				libro = new Libro ();
				libro.LibroId = Convert.ToInt32 (rd [0]);
				libro.Editorial = BDEditorial.BuscarPorId (Convert.ToInt32 (rd [1]));
				libro.Autor = BDAutor.BuscarPorId (Convert.ToInt32 (rd [2]));
				libro.Idioma = BDIdioma.BuscarPorId (Convert.ToInt32 (rd [3]));
				libro.Tipo = BDTipoLibro.BuscarPorId (Convert.ToInt32 (rd [4]));
				libro.DescripcionCorta = rd [5].ToString ();
				libro.DescripcionLarga = rd [6].ToString ();
				libro.AnioEdicion = Convert.ToInt32 (rd [7]);
				libro.Activo = true;
				libro.Titulo = rd [9].ToString ();
				lista.Add (libro);
			}

			rd.Close ();
			return lista;
		}

		public static List<Libro> BuscarPorIdioma (Idioma idi) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Libro> lista;
			Libro libro;

			select = "select * from Libro where iIdiomaId=" + idi.idiomaId + " and bActivo = 1";
			lista = new List<Libro> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				libro = new Libro ();
				libro.LibroId = Convert.ToInt32 (rd [0]);
				libro.Editorial = BDEditorial.BuscarPorId (Convert.ToInt32 (rd [1]));
				libro.Autor = BDAutor.BuscarPorId (Convert.ToInt32 (rd [2]));
				libro.Idioma = BDIdioma.BuscarPorId (Convert.ToInt32 (rd [3]));
				libro.Tipo = BDTipoLibro.BuscarPorId (Convert.ToInt32 (rd [4]));
				libro.DescripcionCorta = rd [5].ToString ();
				libro.DescripcionLarga = rd [6].ToString ();
				libro.AnioEdicion = Convert.ToInt32 (rd [7]);
				libro.Activo = true;
				libro.Titulo = rd [9].ToString ();
				lista.Add (libro);
			}

			rd.Close ();
			return lista;
		}

		public static List<Libro> BuscarPorTipoLibro (TipoLibro tip) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Libro> lista;
			Libro libro;

			select = "select * from Libro where iTipoLibroId=" + tip.TipoLibroId + " and bActivo = 1";
			lista = new List<Libro> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				libro = new Libro ();
				libro.LibroId = Convert.ToInt32 (rd [0]);
				libro.Editorial = BDEditorial.BuscarPorId (Convert.ToInt32 (rd [1]));
				libro.Autor = BDAutor.BuscarPorId (Convert.ToInt32 (rd [2]));
				libro.Idioma = BDIdioma.BuscarPorId (Convert.ToInt32 (rd [3]));
				libro.Tipo = BDTipoLibro.BuscarPorId (Convert.ToInt32 (rd [4]));
				libro.DescripcionCorta = rd [5].ToString ();
				libro.DescripcionLarga = rd [6].ToString ();
				libro.AnioEdicion = Convert.ToInt32 (rd [7]);
				libro.Activo = true;
				libro.Titulo = rd [9].ToString ();
				lista.Add (libro);
			}

			rd.Close ();
			return lista;
		}

		public static List<Libro> BuscarPorTitulo (string palabra) {
			SqlCommand cmd;
			SqlDataReader rd;
			List<Libro> lista;
			Libro libro;
			string select;

			select = "select * from libro where cTitulo like '%" + palabra + "%' and bActivo = 1";
			lista = new List<Libro> ();


			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				libro = new Libro ();
				libro.LibroId = Convert.ToInt32 (rd [0]);
				libro.Editorial = BDEditorial.BuscarPorId (Convert.ToInt32 (rd [1]));
				libro.Autor = BDAutor.BuscarPorId (Convert.ToInt32 (rd [2]));
				libro.Idioma = BDIdioma.BuscarPorId (Convert.ToInt32 (rd [3]));
				libro.Tipo = BDTipoLibro.BuscarPorId (Convert.ToInt32 (rd [4]));
				libro.DescripcionCorta = rd [5].ToString ();
				libro.DescripcionLarga = rd [6].ToString ();
				libro.AnioEdicion = Convert.ToInt32 (rd [7]);
				libro.Activo = true;
				libro.Titulo = rd [9].ToString ();
				lista.Add (libro);
			}

			rd.Close ();
			return lista;
		}

		public static List<Libro> BuscarPorDescCorta (string palabra) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Libro> lista;
			Libro libro;

			select = "select * from Libro where cDescripcionCorta like '%" + palabra + "%' and bActivo = 1";
			lista = new List<Libro> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				libro = new Libro ();
				libro.LibroId = Convert.ToInt32 (rd [0]);
				libro.Editorial = BDEditorial.BuscarPorId (Convert.ToInt32 (rd [1]));
				libro.Autor = BDAutor.BuscarPorId (Convert.ToInt32 (rd [2]));
				libro.Idioma = BDIdioma.BuscarPorId (Convert.ToInt32 (rd [3]));
				libro.Tipo = BDTipoLibro.BuscarPorId (Convert.ToInt32 (rd [4]));
				libro.DescripcionCorta = rd [5].ToString ();
				libro.DescripcionLarga = rd [6].ToString ();
				libro.AnioEdicion = Convert.ToInt32 (rd [7]);
				libro.Activo = true;
				libro.Titulo = rd [9].ToString ();
				lista.Add (libro);
			}

			rd.Close ();
			return lista;
		}

		public static List<Libro> BuscarPorDescLarga (string palabra) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Libro> lista;
			Libro libro;

			select = "select * from Libro where cDescripcionLarga like '%" + palabra + "%' and bActivo = 1";
			lista = new List<Libro> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				libro = new Libro ();
				libro.LibroId = Convert.ToInt32 (rd [0]);
				libro.Editorial = BDEditorial.BuscarPorId (Convert.ToInt32 (rd [1]));
				libro.Autor = BDAutor.BuscarPorId (Convert.ToInt32 (rd [2]));
				libro.Idioma = BDIdioma.BuscarPorId (Convert.ToInt32 (rd [3]));
				libro.Tipo = BDTipoLibro.BuscarPorId (Convert.ToInt32 (rd [4]));
				libro.DescripcionCorta = rd [5].ToString ();
				libro.DescripcionLarga = rd [6].ToString ();
				libro.AnioEdicion = Convert.ToInt32 (rd [7]);
				libro.Activo = true;
				libro.Titulo = rd [9].ToString ();
				lista.Add (libro);
			}

			rd.Close ();
			return lista;
		}

		public static List<Libro> BuscarPorAnioEdicion (int anio) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Libro> lista;
			Libro libro;

			select = "select * from Libro where iAnioEdicion =" + anio + " and bActivo = 1";
			lista = new List<Libro> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				libro = new Libro ();
				libro.LibroId = Convert.ToInt32 (rd [0]);
				libro.Editorial = BDEditorial.BuscarPorId (Convert.ToInt32 (rd [1]));
				libro.Autor = BDAutor.BuscarPorId (Convert.ToInt32 (rd [2]));
				libro.Idioma = BDIdioma.BuscarPorId (Convert.ToInt32 (rd [3]));
				libro.Tipo = BDTipoLibro.BuscarPorId (Convert.ToInt32 (rd [4]));
				libro.DescripcionCorta = rd [5].ToString ();
				libro.DescripcionLarga = rd [6].ToString ();
				libro.AnioEdicion = Convert.ToInt32 (rd [7]);
				libro.Activo = true;
				libro.Titulo = rd [9].ToString ();
				lista.Add (libro);
			}

			rd.Close ();
			return lista;
		}

		public static List<Libro> BuscarPorActivo (bool estado) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Libro> lista;
			Libro libro;
			int activo;

			// Transformo la información del booleano en un bit.
			if (estado == true) {
				activo = 1;
			} else {
				activo = 0;
			}

			select = "select * from Libro where bActivo =" + activo;
			lista = new List<Libro> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				libro = new Libro ();
				libro.LibroId = Convert.ToInt32 (rd [0]);
				libro.Editorial = BDEditorial.BuscarPorId (Convert.ToInt32 (rd [1]));
				libro.Autor = BDAutor.BuscarPorId (Convert.ToInt32 (rd [2]));
				libro.Idioma = BDIdioma.BuscarPorId (Convert.ToInt32 (rd [3]));
				libro.Tipo = BDTipoLibro.BuscarPorId (Convert.ToInt32 (rd [4]));
				libro.DescripcionCorta = rd [5].ToString ();
				libro.DescripcionLarga = rd [6].ToString ();
				libro.AnioEdicion = Convert.ToInt32 (rd [7]);
				// Ver en qué booleano se convierte el cero y el uno.
				libro.Activo = Convert.ToBoolean (rd [8]);
				libro.Titulo = rd [9].ToString ();
				lista.Add (libro);
			}

			rd.Close ();
			return lista;
		}
		
		/// <summary>
		/// Método que busca libros según estén o no en prestamo.
		/// </summary>
		/// <param name="estado">True, en prestamo. False, no en prestamo</param>
		/// <returns>lista de libros</returns>
		public static List<Libro> BuscarLibrosEnPrestamo (bool estado) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Libro libro;
			List<Libro> lista;

			lista = new List<Libro> ();
									
			if (estado == true) {
				select = "select iLibroId from PrestamoLibro where bActivo = 1";
			} else {
				select = "select iLibroId from Libro where Libro.bActivo = 1 and Libro.iLibroId not in (select iLibroId from PrestamoLibro where bActivo = 1 and PrestamoLibro.iLibroId = Libro.iLibroId)";
			}

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				libro = new Libro ();
				libro = BDLibro.BuscarPorId (Convert.ToInt32 (rd [0]));
				lista.Add (libro);
			}

			return lista;
		}	

		public static DataTable Buscar (string titulo, string apellido, string nombre, string tipo, string idioma, string editorial) {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			DataTable tabla;
			string select;

			select = "select Libro.iLibroId as LibroId, Libro.cTitulo as LibroTitulo, Autor.cApellido as AutorApellido, Autor.cNombre as AutorNombre, TipoLibro.cNombre as TipoLibroNombre, Libro.cDescripcionCorta as LibroDescripcionCorta, Idioma.cNombre as IdiomaNombre, Editorial.cNombre as EditorialNombre, Libro.iAnioEdicion as LibroAnioEdicion, Libro.cDescripcionLarga as LibroDescripcionLarga ";
			select +="from Libro, Autor, TipoLibro, Idioma, Editorial ";
			select += "where Libro.bActivo = 1 and Libro.iAutorId = Autor.iAutorId and Libro.iTipoLibroId = TipoLibro.iTipoLibroId and Libro.iIdiomaId = Idioma.iIdiomaId and	Libro.iEditorialId = Editorial.iEditorialId ";
			select += "and Libro.cTitulo like '%" + titulo + "%' and TipoLibro.cNombre like '%" + tipo + "%' and Idioma.cNombre like '%" + idioma + "%' and Editorial.cNombre like '%" + editorial + "%' and Autor.cApellido like '%" + apellido + "%' and Autor.cNombre like '%" + nombre + "%' ";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);
			
			return tabla;
		}

		public static DataTable CargarLista () {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			DataTable tabla;
			string select;

			select = "select libro.iLibroId as LibroId, libro.cTitulo as LibroTitulo, autor.cApellido as AutorApellido, autor.cNombre as AutorNombre, TipoLibro.cNombre as TipoLibroNombre,Libro.cDescripcionCorta as LibroDescripcionCorta, Idioma.cNombre as IdiomaNombre, Editorial.cNombre as EditorialNombre, Libro.iAnioEdicion as LibroAnioEdicion, libro.cDescripcionLarga as LibroDescripcionLarga from libro, idioma, autor, TipoLibro, Editorial where Libro.bActivo = 1 and Libro.iAutorId = Autor.iAutorId and	Libro.iTipoLibroId = TipoLibro.iTipoLibroId and	Libro.iIdiomaId = idioma.iIdiomaId and	Libro.iEditorialId = Editorial.iEditorialId";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);

			return tabla;
		}

		private static void Ingresar (Libro lib) {
			SqlCommand cmd;
			SqlDataReader rd;
			string insert;
			string select;

			insert = "insert into Libro (iEditorialId, iAutorId, iIdiomaId, iTipoLibroId, cDescripcionCorta, cDescripcionLarga, iAnioEdicion, bActivo, cTitulo) values (" + lib.Editorial.EditorialId + ", " + lib.Autor.AutorId + ", " + lib.Idioma.idiomaId + ", " + lib.Tipo.TipoLibroId + ", '" + lib.DescripcionCorta + "', '" + lib.DescripcionLarga + "', " + lib.AnioEdicion + ", 1, '" + lib.Titulo + "')";
			select = "select IDENT_CURRENT ('Libro')";

			cmd = new SqlCommand (insert, BD.Con);
			cmd.ExecuteNonQuery ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();
			rd.Read ();
			lib.LibroId = Convert.ToInt32 (rd [0]);
			rd.Close ();
		}

		private static void Modificar (Libro lib) {
			SqlCommand cmd;
			string update;

			update = "update Libro set iEditorialId=" + lib.Editorial.EditorialId + ", iAutorId=" + lib.Autor.AutorId + ", iIdiomaId=" + lib.Idioma.idiomaId + ", iTipoLibroId=" + lib.Tipo.TipoLibroId + ", cDescripcionCorta='" + lib.DescripcionCorta + "', cDescripcionLarga='" + lib.DescripcionLarga + "', iAnioEdicion=" + lib.AnioEdicion + ", cTitulo='" + lib.Titulo + "' where iLibroId=" + lib.LibroId;

			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}
	}
}
