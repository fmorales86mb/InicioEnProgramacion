using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agrego esta lista de elementos.
using System.Data.SqlClient;

// NOTA: El modificador "static" declara un miembro estático, que pertenece al propio tipo en vez de a un objeto específico.

namespace bibio_fede_2 {

	// Hago pública la clase.
	public class BD {

		// Creo las variables de la clase. 
		public static SqlConnection Con;
		private static string datosCon;

		// Creo los métodos de la clase.

		/// <summary>
		/// Método que establece una conexión.
		/// </summary>
		/// <returns>True si la conexión se estableció. De lo contrario, false.</returns>
		public static bool Conectar () {
            datosCon = "Data Source=PC-CASA\\SQLEXPRESS;Initial Catalog=db_prueba2;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True";
			//datosCon = "Data Source=moncho-pc\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True";
			// Establecemos la cadena de conexión con la BD y la abrimos.
			Con = new SqlConnection (datosCon);
			Con.Open ();

			// Resolvemos qué va a devolver el método Conectar.
			if (Con.State == System.Data.ConnectionState.Open) {
				return true;
			} else {
				return false;
			}
		}

		/// <summary>
		/// Se desconecta de la BD.
		/// </summary>
		/// <returns>Devuelve true si se desconectó. Sino false.</returns>
		public static bool Desconectar () {

			// Cierra la conexión.
			Con.Close ();

			// Resuelvo qué va a devolver el método.
			if (Con.State == System.Data.ConnectionState.Closed) {
				return true;
			} else {
				return false;
			}
		}
	}
}