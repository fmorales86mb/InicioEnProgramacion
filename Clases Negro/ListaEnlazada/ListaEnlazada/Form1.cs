using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEnlazada {
	struct Persona {
		public int Dni;
		public string Nombre;
		public string Apellido;
		public int Edad;
	}

	struct Libro {
		public string Nombre;
		public string Autor;

		// esto es para que cuando meta un libro en un listbos me muestre el nombre y el autor.
		public override string ToString() {
			return this.Nombre + " " + this.Autor;
		}
	}

	public partial class Form1 : Form {
		List<Libro> misLibros = new List<Libro> ();

		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			//this.ListaEnlazada ();
			//this.Conjunto ();
			this.Estructuras ();
		}

		private void ListaEnlazada () {
			// Listas de datos.
			// - La lista tiene un tipo de datos asociado (el tipo de dato de sus elementos).
			// - Hay que hacer el new () antes de usarla.
			// - Es el tipo de datos que usa el ListBox
			// - Tiene un orden.

			List<string> lista_string;
			//List<int> lista_int;
			List<List<string>> lista_lista;
			int i;

			lista_string = new List<string> ();
			lista_lista = new List<List<string>> ();
			
			lista_string.Add("asdfasdF");
			lista_string.Add("ddd");
			string elemento = lista_string[0];

			lista_lista.Add (lista_string);

			i = lista_string.Count;
		}

		private void Conjunto () {
			Dictionary<string, string> dic;

			dic = new Dictionary<string, string> ();

			dic.Add ("federico", "gil");
			dic.Add ("marcelino", "capo");

			string str = dic.Values.First ();
		}

		private void Estructuras () {
			Persona fede;
			List<Persona> lista = new List<Persona> ();

			for (;lista.Count < 20 ; lista.Add (fede)) {
				fede.Nombre = "Federico";
				fede.Apellido = "Morales";
				fede.Edad = 29;
				fede.Dni = lista.Count;
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			Libro lib;

			lib.Nombre = "blah";
			lib.Autor = "asdf";

			// Agrega al listbox.
			this.listBox1.Items.Add (lib.ToString ());

			string nombre = "federico";

			bool contiene = nombre.Contains ("ico");
		
		}

		private void Condiciones () {
			int i = 1;
			int b = 2;
			int c = 4;

			// Entra si i = 1;
			if (i == 1) {
			}

			// entra si i == 1 y b == 2 (&& = AND logico)
			if (i == 1 && b == 2) {
			}

			// Entra si i == 1 o b == 3 (|| = OR logico)
			if (i == 1 || b == 3) {
			}

			if (i == 1 || Chequeaalgo ()) {
			}
		}

		private bool Chequeaalgo () {
			return true;
		}
	}
}
