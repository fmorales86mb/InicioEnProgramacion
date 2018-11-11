using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDeDatos {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
			this.TipoMatriz();
        }

        private void TipoDatoNumerico() {
            int a;			// Numero entero
			double x;		// Numero de punto flotante 
			string a_str;	// Cadena de texto

			// Asignamos un valor a a
			a = 123;

			// Convertimos a a string.
			a_str = a.ToString ();

			// Operadores
			a = a + 1;
        }

		private void TipoDatoString () {
			string nombre;
			string apellido;
			char letra;

			nombre = "marcelino";
			apellido = "morales";

			// Tenes operadores
			nombre = apellido;
			nombre = nombre + apellido;
			nombre = nombre + " " + apellido;

			string numero = "123";
			int num;
			int longitud;

			num = Int32.Parse (numero);
			longitud = nombre.Length;

			nombre = "Federico";
			letra = nombre[1];
		}

		private void TipoArray () {
			int[] array_numerico = new int[30];
			string[] array_string = new string[30];
			char[] array_chars = new char[30];
			int i;
			
			// Completa el array con los numeros del indice 
			i = 0;
			while (i < 30) {
				array_numerico[i] = i + 1;
				i++; // es igual a poner i = i + 1;
			}


			// Agrego strings al array
			i = 0; 
			while (i < 30) {
				array_string[i] = "numero: " + i.ToString ();
				i++;
			}

			// No es lo mismo un array de chars que un string.
			// un string es mucho mas que un array de chars por que (entre otras cosas):
			// un array de chars tiene tama;o fijo y no se puede cambiar
			//

			i = 0;
			while (i < 12) {
				array_chars[i] = 'L';
				i++;
			}
		}

		private void TipoMatriz () {
			int[,] matriz_enteros = new int[10, 10];
			int i, j;

			i = 0;

			while (i < 10) {
				j = 0;

				while (j < 10) {
					matriz_enteros[i, j] = i + j;
					j++;
				}
					
				i++;
			}
		}
    }
}
