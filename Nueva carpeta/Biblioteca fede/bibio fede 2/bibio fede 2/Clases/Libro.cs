using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibio_fede_2 {
	public class Libro {
		public int LibroId;
		public Editorial Editorial;
		public Autor Autor;
		public Idioma Idioma;
		public TipoLibro Tipo;
		public string DescripcionCorta;
		public string DescripcionLarga;
		public int AnioEdicion;
		public bool Activo;
		public string Titulo;

		public override string ToString () {
			return this.Titulo;
		}
	}
}
