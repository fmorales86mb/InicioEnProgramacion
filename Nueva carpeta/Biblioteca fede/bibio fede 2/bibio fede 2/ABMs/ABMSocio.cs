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
	public partial class ABMSocio: Form {
		private Socio Socio;
		
		public ABMSocio () {
			InitializeComponent ();
		}

		public void MostrarFormulario (int id) {
			if (id == 0) {
				this.btnBorrar.Enabled = false;
				this.Socio = new Socio ();
				this.dtAlta.Value = DateTime.Now;
				this.dtBaja.Visible = false;
			} else {
				this.btnBorrar.Enabled = true;
				this.Socio = BDSocio.BuscarPorId (id);
				if (this.Socio.Activo == false) {
					this.tbNombre.Enabled = false;
					this.tbApellido.Enabled = false;
					this.labelBaja.Visible = true;
					this.dtBaja.Visible = true;
					this.dtBaja.Value = this.Socio.FechaDeBaja;
					this.btnBorrar.Enabled = false;
					this.btnGuardar.Enabled = false;
				}
				this.tbNombre.Text = this.Socio.Nombre;
				this.tbApellido.Text = this.Socio.Apellido;
				this.dtAlta.Value = this.Socio.FechaDeAlta;
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
			} else if (this.tbApellido.Text == "") {
				MessageBox.Show ("Faltan completar Campos");
				return;
			} else if (this.tbNombre.Text.IndexOf ("'") >= 0 || this.tbApellido.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("No se pueden ingresar ', ;");
				return;
			}

			this.Socio.Nombre = this.tbNombre.Text;
			this.Socio.Apellido = this.tbApellido.Text;
			this.Socio.FechaDeAlta = DateTime.Now;
			BDSocio.Guardar (Socio);
			this.Close ();
		}

		private void btnBorrar_Click (object sender, EventArgs e) {
			this.Socio.FechaDeBaja = DateTime.Now;
			BDSocio.Borrar (this.Socio.SocioId);
			this.Close ();
		}
	}
}
