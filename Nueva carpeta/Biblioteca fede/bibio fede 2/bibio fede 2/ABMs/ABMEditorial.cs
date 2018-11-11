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
	public partial class ABMEditorial: Form {
		// Creo las variables de la clase primero, así no se "pierden".
		private Editorial MiEditorial;
		// Constructor.
		public ABMEditorial () {
			InitializeComponent ();
		}

		public void MostrarFormulario (int id) {
			// Inicializo mi variable según el caso.
			if (id == 0) {
				this.MiEditorial = new Editorial ();
				this.tbNombre.Text = "";
				this.tbDireccion.Text = "";
				this.btnBorrar.Enabled = false;
			} else {
				this.MiEditorial = new Editorial ();
				this.MiEditorial = BDEditorial.BuscarPorId (id);
				this.tbNombre.Text = this.MiEditorial.Nombre;
				this.tbDireccion.Text = this.MiEditorial.Dirección;
				this.btnBorrar.Enabled = true;
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
			} else if (this.tbNombre.Text.IndexOf ("'") >= 0 || this.tbDireccion.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("No se puede ingresar '");
				return;
			}
			
			this.MiEditorial.Nombre = this.tbNombre.Text;
			this.MiEditorial.Dirección = this.tbDireccion.Text;
			BDEditorial.Guardar (this.MiEditorial);

			this.Close ();
		}

		private void btnBorrar_Click (object sender, EventArgs e) {
			DialogResult respuesta;
			respuesta = MessageBox.Show ("Está seguro que desea borrar esta editorial?", "ch ch ch", MessageBoxButtons.YesNo);

			if (respuesta == DialogResult.Yes) {
				BDEditorial.Borrar (this.MiEditorial.EditorialId);
				this.Close ();
			} else {
			}
		}
	}
}
