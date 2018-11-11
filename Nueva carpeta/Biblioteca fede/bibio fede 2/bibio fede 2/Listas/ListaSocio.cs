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
	public partial class ListaSocio: Form {
		public ListaSocio () {
			InitializeComponent ();
		}

		private void ListaSocio_Load (object sender, EventArgs e) {
			DataTable tabla;
			tabla = BDSocio.CargarTabla ();
			dgSocio.DataSource = tabla;
		}

		private void dgSocio_CellDoubleClick (object sender, DataGridViewCellEventArgs e) {
			int id;
			id = (int) this.dgSocio.CurrentRow.Cells ["Id"].Value;

			Formularios.ABMSocio abm;
			abm = new Formularios.ABMSocio ();
			abm.MostrarFormulario (id);
		}
	}
}
