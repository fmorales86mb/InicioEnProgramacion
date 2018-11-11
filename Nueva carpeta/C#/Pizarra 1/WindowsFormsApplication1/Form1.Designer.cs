namespace WindowsFormsApplication1
{
	partial class formularioPizarra
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
            this.btnPunto = new System.Windows.Forms.Button();
            this.gbPaleta = new System.Windows.Forms.GroupBox();
            this.btnLínea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGrosor = new System.Windows.Forms.ComboBox();
            this.lColor = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.gbPaleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(382, 268);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(15, 32);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(54, 22);
            this.btnPunto.TabIndex = 1;
            this.btnPunto.Text = "Punto";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // gbPaleta
            // 
            this.gbPaleta.Controls.Add(this.btnLínea);
            this.gbPaleta.Controls.Add(this.label1);
            this.gbPaleta.Controls.Add(this.cbGrosor);
            this.gbPaleta.Controls.Add(this.lColor);
            this.gbPaleta.Controls.Add(this.cbColor);
            this.gbPaleta.Controls.Add(this.btnPunto);
            this.gbPaleta.Location = new System.Drawing.Point(12, 12);
            this.gbPaleta.Name = "gbPaleta";
            this.gbPaleta.Size = new System.Drawing.Size(131, 279);
            this.gbPaleta.TabIndex = 2;
            this.gbPaleta.TabStop = false;
            this.gbPaleta.Text = "Paleta";
            // 
            // btnLínea
            // 
            this.btnLínea.Location = new System.Drawing.Point(15, 60);
            this.btnLínea.Name = "btnLínea";
            this.btnLínea.Size = new System.Drawing.Size(54, 22);
            this.btnLínea.TabIndex = 7;
            this.btnLínea.Text = "Línea";
            this.btnLínea.UseVisualStyleBackColor = true;
            this.btnLínea.Click += new System.EventHandler(this.btnLínea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grosor";
            // 
            // cbGrosor
            // 
            this.cbGrosor.FormattingEnabled = true;
            this.cbGrosor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbGrosor.Location = new System.Drawing.Point(62, 230);
            this.cbGrosor.Name = "cbGrosor";
            this.cbGrosor.Size = new System.Drawing.Size(56, 21);
            this.cbGrosor.TabIndex = 5;
            // 
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.Location = new System.Drawing.Point(12, 206);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(31, 13);
            this.lColor.TabIndex = 4;
            this.lColor.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Negro",
            "Azul",
            "Rojo",
            "Verde"});
            this.cbColor.Location = new System.Drawing.Point(62, 203);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(56, 21);
            this.cbColor.TabIndex = 3;
            // 
            // formularioPizarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 303);
            this.Controls.Add(this.gbPaleta);
            this.Controls.Add(this.btnCerrar);
            this.Name = "formularioPizarra";
            this.Text = "Pizarra";
            this.Click += new System.EventHandler(this.formularioPizarra_Load);
            this.gbPaleta.ResumeLayout(false);
            this.gbPaleta.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.GroupBox gbPaleta;
        private System.Windows.Forms.ComboBox cbGrosor;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLínea;
	}
}

