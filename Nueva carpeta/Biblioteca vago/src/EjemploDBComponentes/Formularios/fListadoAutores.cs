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
    public partial class fListadoAutores : Form {

        public fListadoAutores() {
            InitializeComponent();
        }

        private void fListadoAutores_Load(object sender, EventArgs e) {
            SqlCommand Comando;
            SqlDataAdapter Adapter;
            DataTable Tabla;

            // Crea la consulta SQL y le pasa el texto SQL y la conexion a la base de datos.
            Comando = new SqlCommand("SELECT iAutorId, cNombre, cApellido, cApellido AS apellido2 FROM Autor", Global.Conn);
            
            // ni idea que hacen...
            Adapter = new SqlDataAdapter(Comando);
            Tabla = new DataTable();

            // El adapter llena (fill = llenar) la tabla con los datos que devuelven la consulta (la consulta siempre devuelve una tabla)
            Adapter.Fill(Tabla);

            // La tabla se convierte en el origen de datos para la grilla que tenemos en la pantalla.
            // Osea, que los datos de la tabla se muestran en la grilla.
            dgListado.DataSource = Tabla;
        }

        private void btnRefrescar_Click(object sender, EventArgs e) {
            SqlCommand Comando;

            Comando = new SqlCommand("ACA VA EL INSERT EN SQL", Global.Conn);
            Comando.ExecuteNonQuery();
        }
    }
}
