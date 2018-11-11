namespace Dibujo
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
			this.btnDibujar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(470, 369);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnDibujar
			// 
			this.btnDibujar.Location = new System.Drawing.Point(27, 12);
			this.btnDibujar.Name = "btnDibujar";
			this.btnDibujar.Size = new System.Drawing.Size(75, 23);
			this.btnDibujar.TabIndex = 1;
			this.btnDibujar.Text = "Dibujar";
			this.btnDibujar.UseVisualStyleBackColor = true;
			this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 404);
			this.Controls.Add(this.btnDibujar);
			this.Controls.Add(this.btnCerrar);
			this.Name = "frmPrincipal";
			this.Text = "Ventana";
			this.Click += new System.EventHandler(this.frmPrincipal_Click);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnDibujar;
	}
}

