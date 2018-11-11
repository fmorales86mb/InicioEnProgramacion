namespace marcelino_01
{
	partial class frmPrincipal
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
			this.btnEjecutar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(436, 259);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnEjecutar
			// 
			this.btnEjecutar.Location = new System.Drawing.Point(436, 210);
			this.btnEjecutar.Name = "btnEjecutar";
			this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
			this.btnEjecutar.TabIndex = 1;
			this.btnEjecutar.Text = "Ejecutar";
			this.btnEjecutar.UseVisualStyleBackColor = true;
			this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(3, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(508, 192);
			this.panel1.TabIndex = 2;
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 289);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnEjecutar);
			this.Controls.Add(this.btnCerrar);
			this.Name = "frmPrincipal";
			this.Text = "Aplicacion de Prueba";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnEjecutar;
		private System.Windows.Forms.Panel panel1;
	}
}

