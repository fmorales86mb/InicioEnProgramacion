namespace variables
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSumar = new System.Windows.Forms.Button();
			this.tbA = new System.Windows.Forms.TextBox();
			this.btnMemoria = new System.Windows.Forms.Button();
			this.tbB = new System.Windows.Forms.TextBox();
			this.tbResultado = new System.Windows.Forms.TextBox();
			this.btnMImp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(84, 95);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(75, 23);
			this.btnSumar.TabIndex = 0;
			this.btnSumar.Text = "+";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
			// 
			// tbA
			// 
			this.tbA.Location = new System.Drawing.Point(64, 43);
			this.tbA.Name = "tbA";
			this.tbA.Size = new System.Drawing.Size(43, 20);
			this.tbA.TabIndex = 1;
			// 
			// btnMemoria
			// 
			this.btnMemoria.Location = new System.Drawing.Point(84, 137);
			this.btnMemoria.Name = "btnMemoria";
			this.btnMemoria.Size = new System.Drawing.Size(75, 23);
			this.btnMemoria.TabIndex = 2;
			this.btnMemoria.Text = "Memoria";
			this.btnMemoria.UseVisualStyleBackColor = true;
			this.btnMemoria.Click += new System.EventHandler(this.btnMemoria_Click);
			// 
			// tbB
			// 
			this.tbB.Location = new System.Drawing.Point(133, 43);
			this.tbB.Name = "tbB";
			this.tbB.Size = new System.Drawing.Size(43, 20);
			this.tbB.TabIndex = 3;
			// 
			// tbResultado
			// 
			this.tbResultado.Location = new System.Drawing.Point(97, 186);
			this.tbResultado.Name = "tbResultado";
			this.tbResultado.Size = new System.Drawing.Size(43, 20);
			this.tbResultado.TabIndex = 4;
			// 
			// btnMImp
			// 
			this.btnMImp.Location = new System.Drawing.Point(172, 137);
			this.btnMImp.Name = "btnMImp";
			this.btnMImp.Size = new System.Drawing.Size(75, 23);
			this.btnMImp.TabIndex = 5;
			this.btnMImp.Text = "M Imp";
			this.btnMImp.UseVisualStyleBackColor = true;
			this.btnMImp.Click += new System.EventHandler(this.btnMImp_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 296);
			this.Controls.Add(this.btnMImp);
			this.Controls.Add(this.tbResultado);
			this.Controls.Add(this.tbB);
			this.Controls.Add(this.btnMemoria);
			this.Controls.Add(this.tbA);
			this.Controls.Add(this.btnSumar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.TextBox tbA;
		private System.Windows.Forms.Button btnMemoria;
		private System.Windows.Forms.TextBox tbB;
		private System.Windows.Forms.TextBox tbResultado;
		private System.Windows.Forms.Button btnMImp;
	}
}

