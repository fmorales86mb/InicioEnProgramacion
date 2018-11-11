using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibio_fede_2 {
	// Hago pública a la clase.
	public class Idioma {
		// Creo las variables de la clase también públicas.
		public int idiomaId;
		public string Nombre;

		// Modifico el ToString para que el Cb muestre la variable Nombre. El Cb utiliza automáticamente el TS para mostrar la lista. 
		public override string ToString () {
			return this.Nombre;
		}
		 
	}
}
