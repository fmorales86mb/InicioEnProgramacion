using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Consultorio.Listados {
    public partial class ObraSocial : Form {

        public ObraSocial() {
            InitializeComponent();
        }

        private void ObraSocial_Load(object sender, EventArgs e) {
            this.CargarTablaCompleta();
        }

        private void CargarTablaCompleta() {
            this.gvObraSocial.DataSource = Logica.ObraSocial.TablaCompleta();
        }
    }
}
