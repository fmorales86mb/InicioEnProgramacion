using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;

namespace bibio_fede_2 {
	public class BDSocio {
		public static void Guardar (Socio socio) {
			if (socio.SocioId == 0) {
				Ingresar (socio);
			} else {
				Modificar (socio);
			}
		}

		/// <summary>
		/// Borrado lógico. 
		/// </summary>
		/// <param name="id"></param>
		public static void Borrar (int id) {
			SqlCommand cmd;
			string update;

			update = "update Socio set bActivo = 0 where iSocioId =" + id;

			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}

		public static Socio BuscarPorId (int id) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			Socio socio;

			select = "select * from socio where isocioid =" + id;
			socio = new Socio ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			if (rd.Read ()) {
				socio.SocioId = id;
				socio.Nombre = rd [1].ToString ();
				socio.Apellido = rd [2].ToString ();
				socio.FechaDeAlta = Convert.ToDateTime (rd [3]);
				socio.FechaDeBaja = Convert.ToDateTime (rd [4]);
				socio.Activo = Convert.ToBoolean (rd [5]);
				rd.Close ();
				return socio;
			} else {
				return null;
			}
		}

		public static List<Socio> BuscarPorNombre (Socio so) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Socio> lista;
			Socio socio;

			select = "select * from socio where cNombre ='" + so.Nombre + "' and bActivo = 1";
			lista = new List<Socio> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				socio = new Socio ();
				socio.SocioId = Convert.ToInt32 (rd [0]);
				socio.Nombre = rd [1].ToString ();
				socio.Apellido = rd [2].ToString ();
				socio.FechaDeAlta = Convert.ToDateTime (rd [3]);
				socio.FechaDeBaja = Convert.ToDateTime (rd [4]);
				socio.Activo = Convert.ToBoolean (rd [5]);
				lista.Add (socio);
			}

			rd.Close ();
			return lista;
		}

		public static List<Socio> BuscarPorApellido (Socio so) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Socio> lista;
			Socio socio;

			select = "select * from socio where cApellido ='" + so.Apellido + "' and bActivo = 1";
			lista = new List<Socio> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				socio = new Socio ();
				socio.SocioId = Convert.ToInt32 (rd [0]);
				socio.Nombre = rd [1].ToString ();
				socio.Apellido = rd [2].ToString ();
				socio.FechaDeAlta = Convert.ToDateTime (rd [3]);
				socio.FechaDeBaja = Convert.ToDateTime (rd [4]);
				socio.Activo = Convert.ToBoolean (rd [5]);
				lista.Add (socio);
			}

			rd.Close ();
			return lista;
		}

		public static List<Socio> BuscarPorNombreYApellido (Socio so) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Socio> lista;
			Socio socio;

			select = "select * from socio where cNombre ='" + so.Nombre + "' and cApellido ='" + so.Apellido + "' and bActivo = 1";
			lista = new List<Socio> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				socio = new Socio ();
				socio.SocioId = Convert.ToInt32 (rd [0]);
				socio.Nombre = rd [1].ToString ();
				socio.Apellido = rd [2].ToString ();
				socio.FechaDeAlta = Convert.ToDateTime (rd [3]);
				socio.FechaDeBaja = Convert.ToDateTime (rd [4]);
				socio.Activo = Convert.ToBoolean (rd [5]);
				lista.Add (socio);
			}

			rd.Close ();
			return lista;
		}

		public static List<Socio> BuscarPorFechaDeAlta (DateTime fecha) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Socio> lista;
			Socio socio;

			select = "select * from socio where dFechaDeAlta = '" + fecha + "' and bActivo = 1";
			lista = new List<Socio> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				socio = new Socio ();
				socio.SocioId = Convert.ToInt32 (rd [0]);
				socio.Nombre = rd [1].ToString ();
				socio.Apellido = rd [2].ToString ();
				socio.FechaDeAlta = Convert.ToDateTime (rd [3]);
				socio.FechaDeBaja = Convert.ToDateTime (rd [4]);
				socio.Activo = Convert.ToBoolean (rd [5]);
				lista.Add (socio);
			}

			rd.Close ();
			return lista;
		}

		public static List<Socio> BuscarPorFechaDeBaja (DateTime fecha) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Socio> lista;
			Socio socio;

			select = "select * from socio where dFechaDeBaja = '" + fecha + "' and bActivo = 1";
			lista = new List<Socio> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				socio = new Socio ();
				socio.SocioId = Convert.ToInt32 (rd [0]);
				socio.Nombre = rd [1].ToString ();
				socio.Apellido = rd [2].ToString ();
				socio.FechaDeAlta = Convert.ToDateTime (rd [3]);
				socio.FechaDeBaja = Convert.ToDateTime (rd [4]);
				socio.Activo = Convert.ToBoolean (rd [5]);
				lista.Add (socio);
			}

			rd.Close ();
			return lista;
		}

		public static List<Socio> BuscarPorActivo (bool activo) {
			SqlCommand cmd;
			SqlDataReader rd;
			string select;
			List<Socio> lista;
			Socio socio;
			int act;

			act = Convert.ToInt32 (activo);
			select = "select * from socio where bActivo=" + act;
			lista = new List<Socio> ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();

			while (rd.Read ()) {
				socio = new Socio ();
				socio.SocioId = Convert.ToInt32 (rd [0]);
				socio.Nombre = rd [1].ToString ();
				socio.Apellido = rd [2].ToString ();
				socio.FechaDeAlta = Convert.ToDateTime (rd [3]);
				socio.FechaDeBaja = Convert.ToDateTime (rd [4]);
				socio.Activo = Convert.ToBoolean (rd [5]);
				lista.Add (socio);
			}

			rd.Close ();
			return lista;
		}

		public static DataTable CargarTabla () {
			SqlCommand cmd;
			SqlDataAdapter adapter;
			string select;
			DataTable tabla;

			select = "select * from Socio where bActivo = 1";
			tabla = new DataTable ();

			cmd = new SqlCommand (select, BD.Con);
			adapter = new SqlDataAdapter (cmd);
			adapter.Fill (tabla);

			return tabla;
		}

		private static void Ingresar (Socio socio) {
			SqlCommand cmd;
			SqlDataReader rd;
			string insert;
			string select;

			insert = "insert into Socio (cNombre, cApellido, dFechaDeAlta, dFechaDeBaja ,bActivo) values ('" + socio.Nombre + "','" + socio.Apellido + "', '" + socio.FechaDeAlta + "', '" + socio.FechaDeBaja + "', 1 )";
			select = "select IDENT_CURRENT ('Socio')";

			cmd = new SqlCommand (insert, BD.Con);
			cmd.ExecuteNonQuery ();

			cmd = new SqlCommand (select, BD.Con);
			rd = cmd.ExecuteReader ();
			rd.Read ();
			socio.SocioId = Convert.ToInt32 (rd [0]);
			rd.Close ();
		}

		private static void Modificar (Socio socio) {
			SqlCommand cmd;
			string update;
			int act;

			act = Convert.ToInt32 (socio.Activo);
			update = "update Socio set cNombre = '" + socio.Nombre + "', cApellido = '" + socio.Apellido + "', dFechaDeAlta = '" + socio.FechaDeAlta + "', dFechaDeBaja = '" + socio.FechaDeBaja + "', bActivo = " + act + " where iSocioId =" + socio.SocioId;

			cmd = new SqlCommand (update, BD.Con);
			cmd.ExecuteNonQuery ();
		}
	}
}
