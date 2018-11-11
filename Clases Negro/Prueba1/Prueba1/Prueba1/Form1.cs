using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1 {
	public partial class frmPrincipal : Form {
		public frmPrincipal() {
			InitializeComponent();
		}

		private void btnCerrar_Click(object sender, EventArgs e) {
			this.Close ();
		}

		private void btnCopiar_Click(object sender, EventArgs e) {
			if(this.tbNombre.Text=="Federico"){
				this.tbNombre2.Text="Programador";
			}
			else if(this.tbNombre.Text=="Ana Laura"){
				this.tbNombre2.Text="Programadora";
			}
		}

		private void tbNombre_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.listbPersonas.Items.Add(this.tbPersona1.Text);
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			if(this.listbPersonas.SelectedIndex>-1){
				this.listbPersonas.Items.RemoveAt(this.listbPersonas.SelectedIndex);
			}
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			int i=0;
			while(i< this.listbPersonas.Items.Count){
				if ((string) this.listbPersonas.Items[i] == this.tbBuscador.Text){
					this.labelConfirmador.Text="Confirmado";
				}	
				i=i+1;
			}
			if (this.labelConfirmador.Text!="Confirmado"){
				this.labelConfirmador.Text="Desconfirmado";
			}
		}
	}
}
