using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variables {
	public partial class Form1 : Form {
		int m;
		public Form1() {
			InitializeComponent();
		}

		private void btnSumar_Click(object sender, EventArgs e)	{
			int a, b, c;

			//a = Int32.Parse ("44");
			//this.tbA.Text = a.ToString ();

			a = Int32.Parse(this.tbA.Text);
			b = Int32.Parse(this.tbB.Text);
			c = a + b;
			this.tbResultado.Text= c.ToString();
		}

		private void btnMemoria_Click(object sender, EventArgs e)
		{
			m = Int32.Parse (this.tbResultado.Text);
		}

		private void btnMImp_Click(object sender, EventArgs e)
		{
			this.tbA.Text = m.ToString ();

		}

	}
}

	