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
	public partial class ABMTipoLibro: Form {
		private TipoLibro TipoLibro;

		public ABMTipoLibro () {
			InitializeComponent ();
		}

		public void MostrarFormulario (int id) {
			if (id == 0) {
				TipoLibro = new TipoLibro ();
				tbNombre.Text = "";
				tbDescripcion.Text = "";
				btnBorrar.Enabled = false;
			} else {
				TipoLibro = BDTipoLibro.BuscarPorId (id);
				tbNombre.Text = TipoLibro.Nombre;
				tbDescripcion.Text = TipoLibro.Descripcion;
				btnBorrar.Enabled = true;
			}

			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			ShowDialog ();
		}

		private void btnCerrar_Click (object sender, EventArgs e) {
			this.Close ();
		}

		private void btnGuardar_Click (object sender, EventArgs e) {
			if (this.tbNombre.Text == "") {
				MessageBox.Show ("Faltan completar campos");
				return;
			} else if (this.tbNombre.Text.IndexOf ("'") >= 0 || this.tbNombre.Text.IndexOf (";") >= 0) {
				MessageBox.Show ("No se pueden ingresar ', ;");
				return;
			} else if (this.tbDescripcion.Text.IndexOf ("'") >= 0 || this.tbDescripcion.Text.IndexOf (";") >= 0) {
				MessageBox.Show ("No se pueden ingresar ', ;");
				return;
			}

			TipoLibro.Nombre = tbNombre.Text;
			TipoLibro.Descripcion = tbDescripcion.Text;
			BDTipoLibro.Guardar (TipoLibro);
			this.Close ();	
		}

		private void btnBorrar_Click (object sender, EventArgs e) {
			DialogResult respuesta;
			respuesta = MessageBox.Show ("Está seguro que desea borrar este tipo de libro?", "Alerta! :o", MessageBoxButtons.YesNo);

			if (respuesta == DialogResult.Yes) {
				BDTipoLibro.Borrar (TipoLibro.TipoLibroId);
				this.Close ();
			}
		}
	}
}
