namespace bibio_fede_2.Listas {
	partial class ListaAutor {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgListaAutor = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelBuscar = new System.Windows.Forms.Panel();
			this.tbBuscar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnActualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgListaAutor)).BeginInit();
			this.panelBuscar.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgListaAutor
			// 
			this.dgListaAutor.AllowUserToAddRows = false;
			this.dgListaAutor.AllowUserToDeleteRows = false;
			this.dgListaAutor.AllowUserToResizeRows = false;
			this.dgListaAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgListaAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido});
			this.dgListaAutor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgListaAutor.Location = new System.Drawing.Point(0, 0);
			this.dgListaAutor.Name = "dgListaAutor";
			this.dgListaAutor.RowHeadersVisible = false;
			this.dgListaAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgListaAutor.Size = new System.Drawing.Size(652, 372);
			this.dgListaAutor.TabIndex = 0;
			this.dgListaAutor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaAutor_CellDoubleClick);
			// 
			// id
			// 
			this.id.DataPropertyName = "iAutorId";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.id.DefaultCellStyle = dataGridViewCellStyle3;
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			this.id.Width = 50;
			// 
			// nombre
			// 
			this.nombre.DataPropertyName = "cNombre";
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			// 
			// apellido
			// 
			this.apellido.DataPropertyName = "cApellido";
			this.apellido.HeaderText = "Apellido";
			this.apellido.Name = "apellido";
			this.apellido.ReadOnly = true;
			// 
			// panelBuscar
			// 
			this.panelBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBuscar.Controls.Add(this.btnActualizar);
			this.panelBuscar.Controls.Add(this.tbBuscar);
			this.panelBuscar.Controls.Add(this.label1);
			this.panelBuscar.Controls.Add(this.btnBuscar);
			this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBuscar.Location = new System.Drawing.Point(0, 0);
			this.panelBuscar.MaximumSize = new System.Drawing.Size(2000, 1000);
			this.panelBuscar.Name = "panelBuscar";
			this.panelBuscar.Size = new System.Drawing.Size(652, 87);
			this.panelBuscar.TabIndex = 1;
			// 
			// tbBuscar
			// 
			this.tbBuscar.Location = new System.Drawing.Point(58, 31);
			this.tbBuscar.Name = "tbBuscar";
			this.tbBuscar.Size = new System.Drawing.Size(240, 20);
			this.tbBuscar.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Buscar:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(318, 29);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 0;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgListaAutor);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 87);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(652, 372);
			this.panel1.TabIndex = 2;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(416, 29);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(84, 23);
			this.btnActualizar.TabIndex = 3;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// ListaAutor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 459);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelBuscar);
			this.Name = "ListaAutor";
			this.Text = "Lista de Autores";
			this.Load += new System.EventHandler(this.ListaAutor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgListaAutor)).EndInit();
			this.panelBuscar.ResumeLayout(false);
			this.panelBuscar.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgListaAutor;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
		private System.Windows.Forms.Panel panelBuscar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox tbBuscar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnActualizar;
	}
}