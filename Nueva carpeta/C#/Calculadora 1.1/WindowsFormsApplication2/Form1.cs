using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//copiar resolverpasoprevio en lo botones de los numeros. 
//Implementar el resto de las funciones
//control para que sòlo pueda haber una coma.
//control para no poner dos funciones seguidas.

//poner "0" cuando receteo 
//resolver error en la coma (coma + operación tira error)

namespace WindowsFormsApplication2 {
    public partial class Form1 : Form {
		float memoria; //Resultado de la operación entre la memoria anterior y el tb1
		int operador; //Nro que designa una operación
		bool pasoprevio; // permite o no borrar el tb al hacer click en un btn
        bool signoingresado; //determina si hay o no un signo ingresado inmediatamente antes

        public Form1() {
            InitializeComponent();

            this.memoria = 0;
			this.operador = 1;
			this.pasoprevio = true;
            this.signoingresado = true;
            this.tb1.Text = "0";
        }
                
        private void btnCerrar_Click(object sender, EventArgs e) {
			this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.pasosnúmeros(1);
        }

		private void btn2_Click(object sender, EventArgs e)
		{
            this.pasosnúmeros(2);
		}

        private void btn3_Click(object sender, EventArgs e)
        {
            this.pasosnúmeros(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.pasosnúmeros(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.pasosnúmeros(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.pasosnúmeros(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.pasosnúmeros(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.pasosnúmeros(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.pasosnúmeros(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.pasosnúmeros(0);
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            this.resolverpasoprevio();

            if (this.tb1.Text.IndexOf(",") >= 0)
            {
                MessageBox.Show("Número incorrecto.");
            }
            else
            {
                this.tb1.Text = this.tb1.Text + ",";
                this.signoingresado = false;
            }
        }

        private void btnMás_Click(object sender, EventArgs e)
        {
            this.pasos(1);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            this.pasos(2);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            this.pasos(3);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            this.pasos(4);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            this.operar();
            this.tb1.Text = this.memoria.ToString();
            this.pasoprevio = true;
            this.memoria = 0;
            this.operador = 1;
        }

        //
        // Borra el ultimo numero del tb.
        //
        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (this.pasoprevio == false)
            {
                if (this.tb1.TextLength > 0)
                {
                    this.tb1.Text = this.tb1.Text.Remove(this.tb1.TextLength - 1);
                }
            }
        } 

        private void btnCE_Click(object sender, EventArgs e) // borra el tb 
        {
            if (this.signoingresado == false)
            {
                this.tb1.Text = "0";
                this.pasoprevio = true;
            }
        } 

        private void btnC_Click(object sender, EventArgs e) // reinicia 
        {
            this.memoria = 0;
            this.operador = 1;
            this.tb1.Text = "0";
            this.pasoprevio = true;
        }

        void operar() // ejecuta las operaciones matemáticas 
        {
            if (this.tb1.Text == ",") {
                this.tb1.Text = "0";
            }

            if (this.operador == 1)
            {
                this.memoria = this.memoria + float.Parse(this.tb1.Text);
            }
            else if (this.operador == 2)
            {
                this.memoria = this.memoria - float.Parse(this.tb1.Text);
            }
            else if (this.operador == 3)
            {
                this.memoria = this.memoria * float.Parse(this.tb1.Text);
            }
            else if (this.operador == 4)
            {
                this.memoria = this.memoria / float.Parse(this.tb1.Text);
            }
        } 

        void pasos(int signo) // es la mecanica que ejecutan los btn de las operaciones 
        {
            if (signoingresado == false)
            {
                this.operar();
            }
            this.operador = signo;
            this.tb1.Text = this.memoria.ToString();
            this.pasoprevio = true;
            this.signoingresado = true;
        }

        void pasosnúmeros(int número) //es la mecánica que ejecutan los btn de los números 
        {
            this.resolverpasoprevio();
            this.tb1.Text = this.tb1.Text + número;
            this.signoingresado = false;
        } 

        void resolverpasoprevio() // resuelve que se borre el tb1 cuando corresponde 
        {
            if (this.pasoprevio == true)
            {
                this.tb1.Text = "";
                this.pasoprevio = false;
            }
        }
    }
}
