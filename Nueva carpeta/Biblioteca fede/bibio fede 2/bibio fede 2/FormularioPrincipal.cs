using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibio_fede_2 {
	public partial class FormularioPrueba: Form {
		public FormularioPrueba () {
			InitializeComponent ();
		}
		
		// Lo que se ejecuta al mostrar el formulario.
		private void FormularioPrueba_Shown (object sender, EventArgs e) {
			// Ejecuto el método Conectar implementado en BD y resuelvo según lo devuelto.
			if (BD.Conectar () == false) {
				MessageBox.Show ("No se pudo establecer la conexión.");
			}
		}
		
		private void salirToolStripMenuItem_Click (object sender, EventArgs e) {
			Close ();
		}
		
		// Métodos del menú "Nuevo".
		private void nuevoLibroToolStripMenuItem_Click (object sender, EventArgs e) {
			Formularios.ABMLibro abm;
			abm = new Formularios.ABMLibro ();
			abm.MostrarFormulario (0);
		}

		private void nuevoAutorToolStripMenuItem_Click (object sender, EventArgs e) {
			// Creo un formulario abmautor y ejecuto un método del mismo para que muestre el abm con un determinado autor.
			Formularios.ABMAutor abm;
			abm = new Formularios.ABMAutor ();
			abm.MostrarFormulario (0);
		}

		private void nuevoEditorialToolStripMenuItem_Click (object sender, EventArgs e) {
			// Creo un objeto de la clase primero para poder usar sus métodos.
			Formularios.ABMEditorial abm;
			abm = new Formularios.ABMEditorial ();
			abm.MostrarFormulario (0);
		}

		private void nuevoIdiomaToolStripMenuItem_Click (object sender, EventArgs e) {
			// Creo las varialbes del método. Un puntero de la calse abmidioma, luego lo asocio a un nuevo objeto.
			Formularios.ABMIdioma abm;
			abm = new Formularios.ABMIdioma ();
			abm.MostrarFormulario (0);
		}

		private void nuevoTipoLibroToolStripMenuItem_Click (object sender, EventArgs e) {
			Formularios.ABMTipoLibro abm;
			abm = new Formularios.ABMTipoLibro ();
			abm.MostrarFormulario (0);
		}

		private void nuevoBibliotecaToolStripMenuItem_Click (object sender, EventArgs e) {
			Formularios.ABMBiblioteca abm;
			abm = new Formularios.ABMBiblioteca ();
			abm.MostrarFormulario (0);
		}

		private void nuevoSocioToolStripMenuItem_Click (object sender, EventArgs e) {
			Formularios.ABMSocio abm;
			abm = new Formularios.ABMSocio ();

			abm.MostrarFormulario (0);
		}

		private void nuevoPréstamoToolStripMenuItem_Click (object sender, EventArgs e) {
			Formularios.ABMPrestamo abm;
			abm = new Formularios.ABMPrestamo ();

			abm.MostrarFormulario (0);
		}

		// Métodos del menú "Listados".
		private void autoresToolStripMenuItem_Click (object sender, EventArgs e) {
			Listas.ListaAutor form;
			form = new Listas.ListaAutor ();

			// Establezco al form "principal" (this) como form contenedor de "lista".
			form.MdiParent = this;
			// Determino cómo se acompla el form contenido al contenedor.
			form.Dock = DockStyle.Fill;

			form.Show ();
		}

		private void editorialToolStripMenuItem1_Click (object sender, EventArgs e) {
			Listas.ListaEditorial form;
			form = new Listas.ListaEditorial ();

			form.MdiParent = this;
			form.Dock = DockStyle.Fill;

			form.Show ();
		}

		private void idiomaToolStripMenuItem1_Click (object sender, EventArgs e) {
			Listas.ListaIdioma form;
			form = new Listas.ListaIdioma ();

			form.MdiParent = this;
			form.Dock = DockStyle.Fill;

			form.Show ();
		}

		private void tipoLibroToolStripMenuItem1_Click (object sender, EventArgs e) {
			Listas.ListaTipoLibro form;
			form = new Listas.ListaTipoLibro ();

			form.MdiParent = this;
			form.Dock = DockStyle.Fill;

			form.Show ();
		}

		private void bibliotecaToolStripMenuItem1_Click (object sender, EventArgs e) {
			Listas.ListaBiblioteca form;
			form = new Listas.ListaBiblioteca ();

			form.MdiParent = this;
			form.Dock = DockStyle.Fill;

			form.Show ();
		}

		private void librosToolStripMenuItem_Click (object sender, EventArgs e) {
			Listas.ListaLibro form;
			form = new Listas.ListaLibro ();

			form.MdiParent = this;
			form.Dock = DockStyle.Fill;

			form.Show ();
		}

		private void sociosToolStripMenuItem_Click (object sender, EventArgs e) {
			Listas.ListaSocio form;
			form = new Listas.ListaSocio ();

			form.MdiParent = this;
			form.Dock = DockStyle.Fill;

			form.Show ();
		}

		private void préstamosToolStripMenuItem1_Click (object sender, EventArgs e) {
			Listas.ListaPrestamo form;
			form = new Listas.ListaPrestamo ();

			form.MdiParent = this;
			form.Dock = DockStyle.Fill;

			form.Show ();
		}

		// Lo que se ejecuta al cerrar el form.
		private void FormularioPrueba_FormClosing (object sender, FormClosingEventArgs e) {
			BD.Desconectar ();
		}

		

		
    }
}
