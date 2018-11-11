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
    public partial class Usuario : Form {

        public Usuario() {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e) {
           this.CargarTablaCompleta();
        }

        private void CargarTablaCompleta() {
            this.gvUsuario.DataSource = Logica.Usuario.TablaCompleta();
        }
    }
}
