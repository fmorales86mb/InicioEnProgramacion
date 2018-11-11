using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Correcciones y mejoras:
 * - Usar la variable primerPunto en vez de meter todo en opcion.
 * - Inicializar todas las variables de la clase en el constructor.
 * - Usar la propiedad SelectedIndex del combo para consultar el valor seleccionado.
 * Ver: https://msdn.microsoft.com/es-es/library/system.windows.forms.combobox.selectedindex%28v=vs.110%29.aspx
 * 
 */

namespace WindowsFormsApplication1
{
	public partial class formularioPizarra : Form
	{
        int opcion;         // Selecciona punto o linea 1 = punto, 2 linea, 3
      //  bool primerPunto;   // Indica si ya se hizo el primer punto de una linea. 
		Pen color;          // Color del lapiz
		int grosor;            
		Point memoria;      // El primer punto de la linea
        Graphics gráfico;   // Grafico

        public formularioPizarra()
		{
			InitializeComponent();
            this.gráfico = this.CreateGraphics (); //por qué va ahí? porque el grafico se crea en el formulario, primero necesito inicializar el form. para empezar a usar el grafico hay que hacer esto
		}

        //cierra el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void btnPunto_Click(object sender, EventArgs e)
		{
			opcion = 1;
		}

		private void btnLínea_Click(object sender, EventArgs e)
		{
			opcion = 2;
		}

		//determina el color según el combo box
		void colorGrosor ()
		{
			if (this.cbColor.SelectedText == "Negro")
			{
				color = Pens.Black;
			}
			else if (this.cbColor.SelectedText == "Azul")
			{
				color = Pens.Blue;
			}
			else if (this.cbColor.SelectedText == "Rojo")
			{
				color = Pens.Red;
			}
			else if (this.cbColor.SelectedText == "Verde")
			{
				color = Pens.Green;
			}

			//resolver opciones del grosor
		}
		
		//opciones que se ejecutan al hacer click sobre el formulario.
		private void formularioPizarra_Load(object sender, EventArgs e)
		{
            if (opcion == 1)
			{
				if (this.cbColor.SelectedText == "")
				{
					MessageBox.Show("Seleccionar color");
				}
				else
				{
					this.colorGrosor ();
					this.dibujoPunto(color);
				}
			}
			else if (opcion == 2)
			{
				memoria = new Point(MousePosition.X, MousePosition.Y);
				memoria = this.PointToClient(memoria);
				opcion = 3;
			}
			else if (opcion == 3)
			{
				if (this.cbColor.SelectedText == "")
				{
					MessageBox.Show("Seleccionar color");
				}
				else
				{	
					Point segundoPto;
					segundoPto = new Point(MousePosition.X, MousePosition.Y);
					segundoPto = this.PointToClient(segundoPto);
					this.colorGrosor ();
					this.dibujoLinea(color, memoria, segundoPto);
					opcion = 2;
				}
			}
		}

		//dibuja un pto en la posición del puntero
        void dibujoPunto(Pen a)
        {
            Point p;
            p = new Point(MousePosition.X, MousePosition.Y);
            p = this.PointToClient(p);
            gráfico.DrawRectangle(a,p.X, p.Y, 1, 1);
        }
		
        //dibuja una línea
		void dibujoLinea (Pen c, Point a, Point b)
		{
			this.gráfico.DrawLine (c, a, b);
		}
	}
}
