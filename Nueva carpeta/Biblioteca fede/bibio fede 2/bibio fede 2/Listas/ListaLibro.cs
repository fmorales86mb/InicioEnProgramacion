using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibio_fede_2.Listas {
	public partial class ListaLibro: Form {
		public ListaLibro () {
			InitializeComponent ();
		}

		private void ListaLibro_Load (object sender, EventArgs e) {
			DataTable tabla;
			tabla = BDLibro.CargarLista ();

			this.dgListaLibro.DataSource = tabla;

			// No se muestra el valor de la celda en el dg.
			/*for (int i = 0; this.dgListaLibro.RowCount > i; i++) {
				this.dgListaLibro.Rows [i].Cells [0].Value = "perro";
			}*/			
		}

		private void dgListaLibro_CellDoubleClick (object sender, DataGridViewCellEventArgs e) {
			int id;
			id = (int) this.dgListaLibro.CurrentRow.Cells ["id"].Value;

			Formularios.ABMLibro abm;
			abm = new Formularios.ABMLibro ();
			abm.MostrarFormulario (id);
		}

		private void btnBuscar_Click (object sender, EventArgs e) {
			DataTable tabla;

			if (this.tbApellidoAutor.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("El campo contiene elementos inválidos");
				return;
			} else if (this.tbNombreAutor.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("El campo contiene elementos inválidos");
				return;
			} else if (this.tbEditorial.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("El campo contiene elementos inválidos");
				return;
			} else if (this.tbIdioma.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("El campo contiene elementos inválidos");
				return;
			} else if (this.tbTipoLibro.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("El campo contiene elementos inválidos");
				return;
			} else if (this.tbTitulo.Text.IndexOf ("'") >= 0) {
				MessageBox.Show ("El campo contiene elementos inválidos");
				return;
			}

			tabla = BDLibro.Buscar (this.tbTitulo.Text, this.tbApellidoAutor.Text, this.tbNombreAutor.Text, this.tbTipoLibro.Text, this.tbIdioma.Text, this.tbEditorial.Text);
			this.dgListaLibro.DataSource = tabla;
		}
	}
}
