using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibio_fede_2 {
	public class Prestamo {
		public int Id;
		public Socio Socio;
		public Libro Libro;
		public DateTime FechaSalida;
		public DateTime FechaDevolucion;
		public bool Activo;
	}
}
