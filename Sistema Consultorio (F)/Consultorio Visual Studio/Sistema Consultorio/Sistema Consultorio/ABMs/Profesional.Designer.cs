namespace Sistema_Consultorio.ABMs {
    partial class Profesional {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPolizaSeguro = new System.Windows.Forms.TextBox();
            this.tbDirProfesional = new System.Windows.Forms.TextBox();
            this.tbDirPersonal = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEspecialidades = new System.Windows.Forms.TabPage();
            this.gvEspecialidadDeProfesional = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarEspecialidad = new System.Windows.Forms.Button();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.tabTratamientos = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregarTratamiento = new System.Windows.Forms.Button();
            this.cbTratamiento = new System.Windows.Forms.ComboBox();
            this.gvTratamientoDeProfesional = new System.Windows.Forms.DataGridView();
            this.IdTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoTratamientoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuitarTratamiento = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEspecialidadDeProfesional)).BeginInit();
            this.tabTratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTratamientoDeProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPolizaSeguro);
            this.groupBox1.Controls.Add(this.tbDirProfesional);
            this.groupBox1.Controls.Add(this.tbDirPersonal);
            this.groupBox1.Controls.Add(this.tbTelefono);
            this.groupBox1.Controls.Add(this.tbMatricula);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesional";
            // 
            // tbPolizaSeguro
            // 
            this.tbPolizaSeguro.Location = new System.Drawing.Point(452, 97);
            this.tbPolizaSeguro.Name = "tbPolizaSeguro";
            this.tbPolizaSeguro.Size = new System.Drawing.Size(143, 20);
            this.tbPolizaSeguro.TabIndex = 13;
            // 
            // tbDirProfesional
            // 
            this.tbDirProfesional.Location = new System.Drawing.Point(452, 62);
            this.tbDirProfesional.Name = "tbDirProfesional";
            this.tbDirProfesional.Size = new System.Drawing.Size(143, 20);
            this.tbDirProfesional.TabIndex = 12;
            // 
            // tbDirPersonal
            // 
            this.tbDirPersonal.Location = new System.Drawing.Point(452, 28);
            this.tbDirPersonal.Name = "tbDirPersonal";
            this.tbDirPersonal.Size = new System.Drawing.Size(143, 20);
            this.tbDirPersonal.TabIndex = 11;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(127, 129);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(143, 20);
            this.tbTelefono.TabIndex = 10;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(127, 97);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(143, 20);
            this.tbMatricula.TabIndex = 9;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(127, 62);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(143, 20);
            this.tbApellido.TabIndex = 8;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(127, 28);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(143, 20);
            this.tbNombre.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nro. de póliza de seguro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección profesional:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dirección personal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro. de Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(555, 516);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(369, 516);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(463, 516);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEspecialidades);
            this.tabControl1.Controls.Add(this.tabTratamientos);
            this.tabControl1.Location = new System.Drawing.Point(12, 191);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 319);
            this.tabControl1.TabIndex = 5;
            // 
            // tabEspecialidades
            // 
            this.tabEspecialidades.BackColor = System.Drawing.Color.Transparent;
            this.tabEspecialidades.Controls.Add(this.gvEspecialidadDeProfesional);
            this.tabEspecialidades.Controls.Add(this.label8);
            this.tabEspecialidades.Controls.Add(this.btnAgregarEspecialidad);
            this.tabEspecialidades.Controls.Add(this.cbEspecialidad);
            this.tabEspecialidades.Location = new System.Drawing.Point(4, 22);
            this.tabEspecialidades.Name = "tabEspecialidades";
            this.tabEspecialidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabEspecialidades.Size = new System.Drawing.Size(624, 293);
            this.tabEspecialidades.TabIndex = 0;
            this.tabEspecialidades.Text = "Especialidades";
            // 
            // gvEspecialidadDeProfesional
            // 
            this.gvEspecialidadDeProfesional.AllowUserToAddRows = false;
            this.gvEspecialidadDeProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEspecialidadDeProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion,
            this.Quitar});
            this.gvEspecialidadDeProfesional.Location = new System.Drawing.Point(6, 61);
            this.gvEspecialidadDeProfesional.Name = "gvEspecialidadDeProfesional";
            this.gvEspecialidadDeProfesional.RowHeadersVisible = false;
            this.gvEspecialidadDeProfesional.Size = new System.Drawing.Size(612, 226);
            this.gvEspecialidadDeProfesional.TabIndex = 0;
            this.gvEspecialidadDeProfesional.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvEspecialidadDeProfesional_CellMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "EspecialidadId";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // Quitar
            // 
            this.Quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "X";
            this.Quitar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Quitar.HeaderText = "";
            this.Quitar.MinimumWidth = 24;
            this.Quitar.Name = "Quitar";
            this.Quitar.ReadOnly = true;
            this.Quitar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Quitar.Width = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Especialidad:";
            // 
            // btnAgregarEspecialidad
            // 
            this.btnAgregarEspecialidad.Location = new System.Drawing.Point(353, 22);
            this.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            this.btnAgregarEspecialidad.Size = new System.Drawing.Size(140, 23);
            this.btnAgregarEspecialidad.TabIndex = 3;
            this.btnAgregarEspecialidad.Text = "Agregar Especialidad";
            this.btnAgregarEspecialidad.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidad.Click += new System.EventHandler(this.btnAgregarEspecialidad_Click);
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(97, 22);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(214, 21);
            this.cbEspecialidad.TabIndex = 4;
            // 
            // tabTratamientos
            // 
            this.tabTratamientos.BackColor = System.Drawing.Color.Transparent;
            this.tabTratamientos.Controls.Add(this.label9);
            this.tabTratamientos.Controls.Add(this.btnAgregarTratamiento);
            this.tabTratamientos.Controls.Add(this.cbTratamiento);
            this.tabTratamientos.Controls.Add(this.gvTratamientoDeProfesional);
            this.tabTratamientos.Location = new System.Drawing.Point(4, 22);
            this.tabTratamientos.Name = "tabTratamientos";
            this.tabTratamientos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTratamientos.Size = new System.Drawing.Size(624, 293);
            this.tabTratamientos.TabIndex = 1;
            this.tabTratamientos.Text = "Tratamientos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tratamiento:";
            // 
            // btnAgregarTratamiento
            // 
            this.btnAgregarTratamiento.Location = new System.Drawing.Point(353, 22);
            this.btnAgregarTratamiento.Name = "btnAgregarTratamiento";
            this.btnAgregarTratamiento.Size = new System.Drawing.Size(140, 23);
            this.btnAgregarTratamiento.TabIndex = 6;
            this.btnAgregarTratamiento.Text = "Agregar Tratamiento";
            this.btnAgregarTratamiento.UseVisualStyleBackColor = true;
            this.btnAgregarTratamiento.Click += new System.EventHandler(this.btnAgregarTratamiento_Click);
            // 
            // cbTratamiento
            // 
            this.cbTratamiento.FormattingEnabled = true;
            this.cbTratamiento.Location = new System.Drawing.Point(97, 22);
            this.cbTratamiento.Name = "cbTratamiento";
            this.cbTratamiento.Size = new System.Drawing.Size(214, 21);
            this.cbTratamiento.TabIndex = 7;
            // 
            // gvTratamientoDeProfesional
            // 
            this.gvTratamientoDeProfesional.AllowUserToAddRows = false;
            this.gvTratamientoDeProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTratamientoDeProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTratamiento,
            this.NombreTratamiento,
            this.EstadoTratamientoNombre,
            this.Horario,
            this.FechaInicio,
            this.FechaFin,
            this.QuitarTratamiento});
            this.gvTratamientoDeProfesional.Location = new System.Drawing.Point(6, 61);
            this.gvTratamientoDeProfesional.Name = "gvTratamientoDeProfesional";
            this.gvTratamientoDeProfesional.RowHeadersVisible = false;
            this.gvTratamientoDeProfesional.Size = new System.Drawing.Size(612, 226);
            this.gvTratamientoDeProfesional.TabIndex = 1;
            this.gvTratamientoDeProfesional.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvTratamientoDeProfesional_CellMouseClick);
            // 
            // IdTratamiento
            // 
            this.IdTratamiento.DataPropertyName = "EspecialidadId";
            this.IdTratamiento.HeaderText = "ID";
            this.IdTratamiento.Name = "IdTratamiento";
            this.IdTratamiento.ReadOnly = true;
            this.IdTratamiento.Visible = false;
            // 
            // NombreTratamiento
            // 
            this.NombreTratamiento.HeaderText = "Nombre";
            this.NombreTratamiento.Name = "NombreTratamiento";
            this.NombreTratamiento.ReadOnly = true;
            // 
            // EstadoTratamientoNombre
            // 
            this.EstadoTratamientoNombre.DataPropertyName = "Nombre";
            this.EstadoTratamientoNombre.HeaderText = "Estado del Tratamiento";
            this.EstadoTratamientoNombre.Name = "EstadoTratamientoNombre";
            this.EstadoTratamientoNombre.ReadOnly = true;
            this.EstadoTratamientoNombre.Width = 150;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Descripcion";
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Width = 150;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Comienzo";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Finalización";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // QuitarTratamiento
            // 
            this.QuitarTratamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "X";
            this.QuitarTratamiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.QuitarTratamiento.HeaderText = "";
            this.QuitarTratamiento.MinimumWidth = 24;
            this.QuitarTratamiento.Name = "QuitarTratamiento";
            this.QuitarTratamiento.ReadOnly = true;
            this.QuitarTratamiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QuitarTratamiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QuitarTratamiento.Width = 24;
            // 
            // Profesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 551);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Profesional";
            this.Text = "Profesional";
            this.Load += new System.EventHandler(this.Profesional_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabEspecialidades.ResumeLayout(false);
            this.tabEspecialidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEspecialidadDeProfesional)).EndInit();
            this.tabTratamientos.ResumeLayout(false);
            this.tabTratamientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTratamientoDeProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPolizaSeguro;
        private System.Windows.Forms.TextBox tbDirProfesional;
        private System.Windows.Forms.TextBox tbDirPersonal;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEspecialidades;
        private System.Windows.Forms.TabPage tabTratamientos;
        private System.Windows.Forms.DataGridView gvEspecialidadDeProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarEspecialidad;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregarTratamiento;
        private System.Windows.Forms.ComboBox cbTratamiento;
        private System.Windows.Forms.DataGridView gvTratamientoDeProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoTratamientoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewButtonColumn QuitarTratamiento;
    }
}