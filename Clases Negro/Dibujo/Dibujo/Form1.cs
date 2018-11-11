using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dibujo {
	namespace OtraCosa {
		public struct Aaaa {
			int i;
		}
	}

	public struct NuevoTipo {
		string algo;
		System.String str;
		String s;
		bool x;
		Int16 w;
	}

	public partial class frmPrincipal : Form {
		Graphics grafico;

		public frmPrincipal () {
			InitializeComponent ();

			this.grafico = this.CreateGraphics ();
		}

		private void btnCerrar_Click (object sender, EventArgs e) {
			this.Close ();
		}

		private void Punto (double x, double y) {
			grafico.DrawRectangle(Pens.Blue, (int) x + this.Size.Width / 2, (int)y + this.Size.Height / 2 -30, 1, 1);
		}

		private void DibujarEjeY () {
			for (int i =-200 ; i<200; i++){
				this.Punto (0,i);
			}	
		}

		private void DibujarEjeX()
		{
			for (int i = -200; i < 200; i++)
			{
				this.Punto(i,0);
			}
		}

		private void DibujarFuncion (){
			System.Math.Sin (12);
			for (int i = -150; i <150;i++)	{
				this.Punto (i, this.Funcion (i/10) * 20);
				//this.Punto(i, System.Math.Sin (i /10) *20);
			}
		}

		private double Funcion (double x) {
			System.Threading.Thread.Sleep(1);

			return System.Math.Sin (x) + 5; 
		}

		private void btnDibujar_Click(object sender, EventArgs e) {
			// Dibuja una linea.
			//grafico.DrawLine (Pens.Blue, new Point (this.Size.Width / 2, this.Size.Height / 2), new Point (0, 0));

			/*for (int i = 0; i < 50; i++) {
				this.Punto (i, i);
			}*/
			this.DibujarEjeX ();
			this.DibujarEjeY ();
			//this.DibujarFuncion ();
		}

		private void frmPrincipal_Click(object sender, EventArgs e)	{
			Point p;

			p = new Point (MousePosition.X, MousePosition.Y);
			p = this.PointToClient (p);

			grafico.DrawRectangle(Pens.Blue, p.X, p.Y, 1, 1);
		}
	}
}
