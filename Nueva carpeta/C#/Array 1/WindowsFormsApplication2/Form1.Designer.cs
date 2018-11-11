namespace WindowsFormsApplication2
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
			this.btnCerrar = new System.Windows.Forms.Button();
			this.tb1 = new System.Windows.Forms.TextBox();
			this.lb = new System.Windows.Forms.ListBox();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(213, 223);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(62, 26);
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// tb1
			// 
			this.tb1.Location = new System.Drawing.Point(42, 48);
			this.tb1.Name = "tb1";
			this.tb1.Size = new System.Drawing.Size(69, 20);
			this.tb1.TabIndex = 1;
			this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnIngresar_Click);
			// 
			// lb
			// 
			this.lb.FormattingEnabled = true;
			this.lb.Location = new System.Drawing.Point(46, 102);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(124, 121);
			this.lb.TabIndex = 2;
			// 
			// btnIngresar
			// 
			this.btnIngresar.Location = new System.Drawing.Point(117, 41);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(66, 32);
			this.btnIngresar.TabIndex = 3;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			this.btnIngresar.Enter += new System.EventHandler(this.btnIngresar_Click);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Location = new System.Drawing.Point(202, 41);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(70, 32);
			this.btnOrdenar.TabIndex = 4;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.tb1);
			this.Controls.Add(this.btnCerrar);
			this.Name = "Form1";
			this.Text = "Array";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.TextBox tb1;
		private System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Button btnOrdenar;
	}
}

