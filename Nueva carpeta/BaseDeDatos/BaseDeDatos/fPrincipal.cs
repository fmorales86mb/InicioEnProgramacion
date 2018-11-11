using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e) {
            if (DB.Conectar()) {
                MessageBox.Show("Conecto!");

            } else {
                MessageBox.Show("No Conecto");
            }
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e) {
            Autor autor = new Autor();

            autor.Nombre = tbNombre.Text;
            autor.Apellido = tbApellido.Text;

            if (DB.GuardarAutor(autor)) {
                MessageBox.Show("Autor guardado con exito");

            } else {
                MessageBox.Show("Error, no se pudo guardar el autor");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            DB.BorrarAutorPorNombre(tbNombre.Text);
        }

        private void btnLeer_Click(object sender, EventArgs e) {
            Autor au;
            au = DB.LeerAutorPorId(int.Parse(tbId.Text));

            if (au != null) {
                MessageBox.Show("OK");
            }
        }
    }
}
