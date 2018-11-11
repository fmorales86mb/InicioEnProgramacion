using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
	public partial class Form1 : Form
	{
		int[] array;
		bool reiniciar = false;

		public Form1()
		{
			InitializeComponent();
		}
		
		//Cierra el formulario
		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//ordena el array de menor a mayor
		void ordenar () 
		{
			for (int i = 1; i < this.array.Count();)
			{
				if (array[i]<array[i-1])
				{
					int memoria;
					memoria=array[i];
					array[i]=array [i-1];
					array [i-1] = memoria;
					i=1;
				} else {
					i++;
				}
			}
		}

        //establece límite del array igual a la cantidad de items del lb.
        //ingresa los items del lb en el array
        void ingresardatos()
        {
            this.array = new int[this.lb.Items.Count];
            int i;
            i = 0;
            while (i < this.lb.Items.Count)
            {
                //convierte el item i del lb en un string y después en un int
                int a = Int32.Parse((string)this.lb.Items[i]);
                this.array[i] = a;
                i++;
            }
        }

		//pisa los elementos del array en el lb
		void imprimirArray() 
		{
			for (int i = 0; i < this.array.Count(); i++)
			{ 
				this.lb.Items [i] = this.array [i];
			}
		}

		//ejecuta ingresardatos, luego ordenar, luego impirmirArray y cambia el bool a true. Muestra en el lb al array ordenado.
        private void btnOrdenar_Click(object sender, EventArgs e)
		{
            this.ingresardatos();			
			this.ordenar();
			this.imprimirArray();
			reiniciar=true;
		}

		//Si el bool reiniciar es true, entonces limpia al lb y cambia al bool a false. 
		//Coorrobora que en el tb se ingrese un int y si es así lo agrega al lb.
		private void btnIngresar_Click(object sender, EventArgs e) {
			if (reiniciar == true)
			{
				this.lb.Items.Clear();
				reiniciar =false;
			}
			int numeroarray;
			bool corroborar = int.TryParse(this.tb1.Text, out numeroarray);

            if (corroborar == true)
            {
                this.lb.Items.Add(this.tb1.Text);
                this.tb1.Text = "";
            }
            else
            {
                this.tb1.Text = "";
                //No funciona misteriosamente
                //MessageBox.Show("Ingresar sólo números enteros");
            }
		}
	}
}

//Tira error cuando se ejecuta btnOrdenar dos veces.. ver
