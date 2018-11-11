using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EjemploDBComponentes {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e) {
            fListadoAutores form = new fListadoAutores();

            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e) {
            // Abrimos la conexion con la base de datos.
			Global.Conn = new SqlConnection ("Data Source=moncho-pc\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");

            try {
                lbEstado.Text = "Conectando con la DB..";
                Global.Conn.Open();
                lbEstado.Text = "Conexion realizada con exito";

            } catch (Exception ex) {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                Global.Conn.Close ();

            } catch (Exception ex) {
                MessageBox.Show("Error:" + ex.Message);
            }            
        }
    }
}
