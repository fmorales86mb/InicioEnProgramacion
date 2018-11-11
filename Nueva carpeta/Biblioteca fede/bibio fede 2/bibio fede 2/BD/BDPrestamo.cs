using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace bibio_fede_2 {
	public class BDPrestamo {

		public static DataTable CargarTabla () {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			string select;
			DataTable tabla;

			select = "select Socio.cApellido, socio.cNombre, Libro.cTitulo, PrestamoLibro.dFechaSalida, PrestamoLibro.iPrestamoLibroId from Socio, Libro, PrestamoLibro where PrestamoLibro.bActivo = 1 and PrestamoLibro.iLibroId = Libro.iLibroId and	PrestamoLibro.iSocioId = Socio.iSocioId";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);

			return tabla;
		}

		public static void Guardar (Prestamo prestamo) {
			if (prestamo.Id == 0) {
				BDPrestamo.Ingresar (prestamo);
			} else {
				BDPrestamo.Modificar (prestamo);
			}
		}

		public static void Borrar (int id) {
			SqlCommand cmd;
			string update;

			update = "update PrestamoLibro set bActivo = 0 where iPrestamoLibroId =" + id;

			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}

		public static Prestamo BuscarPorId (int id) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Prestamo prestamo;

			select = "select * from PrestamoLibro where iPrestamoLibroId =" + id;
			prestamo = new Prestamo ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			rd.Read ();
			prestamo.Id = Convert.ToInt32 (rd [0]);
			prestamo.Socio = BDSocio.BuscarPorId (Convert.ToInt32 (rd [1]));
			prestamo.Libro = BDLibro.BuscarPorId (Convert.ToInt32 (rd [2]));
			prestamo.FechaSalida = Convert.ToDateTime (rd [3]);
			prestamo.FechaDevolucion = Convert.ToDateTime (rd [4]);
			prestamo.Activo = Convert.ToBoolean (rd [5]);

			rd.Close ();
			return prestamo;
		}

		public static DataTable Buscar (string nombre, string apellido, string titulo, DateTime desde, DateTime hasta) {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			DataTable tabla;
			string select;

			select = "select Socio.cNombre, Socio.cApellido, Libro.cTitulo, PrestamoLibro.dFechaSalida from Socio, Libro, PrestamoLibro where PrestamoLibro.iLibroId = Libro.iLibroId and PrestamoLibro.iSocioId= Socio.iSocioId ";

			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);

			return tabla;
		}

		private static void Ingresar (Prestamo prestamo) {
			SqlCommand cmd;
			SqlDataReader rd;
			string insert;
			string select;

			insert = "insert into prestamolibro (bActivo, isocioid, iLibroId, dFechaSalida, dFechaDevolucion) values (1," + prestamo.Socio.SocioId + "," + prestamo.Libro.LibroId + ",'" + prestamo.FechaSalida + "','" + prestamo.FechaDevolucion + "')";
			select = "select IDENT_CURRENT ('PrestamoLibro') as id";

			cmd = new SqlCommand (insert, BD.Con);
			cmd.ExecuteNonQuery ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();
			rd.Read ();

			prestamo.Id = Convert.ToInt32 (rd [0]);

			rd.Close ();
		}

		private static void Modificar (Prestamo prestamo) {
			SqlCommand cmd;
			string update;

			update = "update PrestamoLibro set iSocioId=" + prestamo.Socio.SocioId + ", iLibroId=" + prestamo.Libro.LibroId + ", dFechaSalida='" + prestamo.FechaSalida + "', dFechaDevolucion='" + prestamo.FechaDevolucion + "' where iPrestamoLibroId=" + prestamo.Id;

			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}
	}
}
