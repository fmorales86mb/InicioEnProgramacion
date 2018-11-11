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
	public partial class ListaPrestamo: Form {
		public ListaPrestamo () {
			InitializeComponent ();
		}

		private void ListaPrestamo_Load (object sender, EventArgs e) {
			DataTable tabla;
			tabla = BDPrestamo.CargarTabla ();

			this.dgPrestamo.DataSource = tabla;
		}
	}
}
