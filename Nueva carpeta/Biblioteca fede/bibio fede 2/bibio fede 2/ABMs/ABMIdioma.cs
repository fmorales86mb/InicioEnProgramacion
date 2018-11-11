using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibio_fede_2.Formularios {
	public partial class ABMIdioma: Form {
		private Idioma Idioma;

		public ABMIdioma () {
			InitializeComponent ();
		}

		public void MostrarFormulario (int id) {
			if (id == 0) {
				this.Idioma = new Idioma ();
				tbNombre.Text = "";
				btnBorrar.Enabled = false;
			} else {
				Idioma = new Idioma ();
				Idioma = BDIdioma.BuscarPorId (id);
				tbNombre.Text = Idioma.Nombre;
				btnBorrar.Enabled = true;
			}

			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.ShowDialog ();
		}

		private void btnCerrar_Click (object sender, EventArgs e) {
			this.Close ();
		}

		private void btnGuardar_Click (object sender, EventArgs e) {
			if (this.tbNombre.Text == "") {
				MessageBox.Show ("Faltan completar campos");
				return;
			} else if (this.tbNombre.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("No se puede ingresar '");
				return;
			}

			Idioma.Nombre = tbNombre.Text;
			BDIdioma.Guardar (Idioma);
			this.Close ();			
		}

		private void btnBorrar_Click (object sender, EventArgs e) {
			// Creo las variables.
			DialogResult respuesta;
			// Inicializo las variables.
			respuesta = MessageBox.Show ("Seguro desea borrar este idioma?", "Wow wow wow!", MessageBoxButtons.YesNo);

			// Resuelvo según la respuesta.
			if (respuesta == DialogResult.Yes) {
				BDIdioma.Borrar (Idioma.idiomaId);
				this.Close ();
			} else {
			}
		}
	}
}
