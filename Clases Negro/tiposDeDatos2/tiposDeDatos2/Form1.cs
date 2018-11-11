using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiposDeDatos2 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			Libro lib = new Libro ();
			Biblioteca biblio = new Biblioteca ();
			Libro lib2;

			lib.Autor = "Marx";
			lib.Editorial = "Progreso";
			lib.Titulo = "El capital";

			biblio.AgregarLibro (lib, 2);

			lib2 = biblio.DameLibro ("El capital");
		}
	}

	class Libro {
		public string Titulo;
		public string Autor;
		public string Editorial;
	}

	class Biblioteca {
		public void AgregarLibro (Libro lib, int estante) {
		}

		public int Buscar (string titulo) {
		}

		public Libro DameLibro (string titulo) {
		}
	}


	class Calculadora {
		private int memoria;

		public int sumarMem (int b)	{
			return memoria + b;
		}

		public int restarMem (int b) {
			return memoria - b;
		}

		public void GuardarMemoria (int x) {
			memoria = x;
		}	
	}
}
