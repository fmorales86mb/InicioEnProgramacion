using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marcelino_01 {
	public partial class frmPrincipal : Form {
		public frmPrincipal() {
			InitializeComponent();
		}

		private void btnCerrar_Click(object sender, EventArgs e) {
			this.Close ();
		}

		private void btnEjecutar_Click(object sender, EventArgs e) {
			System.Drawing.Bitmap bmp;
		
			bmp = new System.Drawing.Bitmap (200, 200);
		}
	}

	public class Automovil {
		protected string Modelo;
		protected bool Encendido;

		public string getModelo() {
			return this.Modelo;
		}

		public virtual void Encender() {
			this.Encendido = true;
		}

		public virtual void Apagar() {
			this.Encendido = false;
		}
	}

	public class Camion : Automovil	{
		public Camion () {
			this.Modelo = "Camion";
		}

		public override void Encender() {
			base.Encender();
		}

		public override void Apagar (){
			base.Apagar();
		}
	}

	public class AutoDeCarreras : Automovil {
		public AutoDeCarreras () {
			this.Modelo = "AutoDeCarreras";
		}
	}
}
