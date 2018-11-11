using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibio_fede_2 {

	// La hago pública.
	public class TipoLibro {
		// Creo las variables de la clase y las hago públicas.
		public int TipoLibroId;
		public string Nombre;
		public string Descripcion;

		public override string ToString () {
			return this.Nombre;
		}
	}
}
