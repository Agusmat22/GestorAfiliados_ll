namespace GestorAfiliados_ll
{
    partial class FormCargaDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargaDatos));
            lblConfiguracion = new Label();
            btnVolver = new PictureBox();
            btnSelectorArchivo = new Button();
            txtRuta = new TextBox();
            grpTipoGuardado = new GroupBox();
            rdbAgregar = new RadioButton();
            rdbSobreescribir = new RadioButton();
            grpPosiciones = new GroupBox();
            txtDni = new TextBox();
            txtPlan = new TextBox();
            txtInterno = new TextBox();
            txtCredencial = new TextBox();
            txtEntidad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblDni = new Label();
            lblPlan = new Label();
            lblInterno = new Label();
            lblCredencial = new Label();
            lblEntidad = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            btnCargar = new Button();
            lblEmpresa = new Label();
            cmbEmpresa = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            grpTipoGuardado.SuspendLayout();
            grpPosiciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblConfiguracion
            // 
            lblConfiguracion.AutoSize = true;
            lblConfiguracion.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfiguracion.ForeColor = Color.FromArgb(13, 51, 70);
            lblConfiguracion.Location = new Point(372, 20);
            lblConfiguracion.Name = "lblConfiguracion";
            lblConfiguracion.Size = new Size(179, 32);
            lblConfiguracion.TabIndex = 0;
            lblConfiguracion.Text = "Carga de datos";
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(42, 40);
            btnVolver.SizeMode = PictureBoxSizeMode.Zoom;
            btnVolver.TabIndex = 10;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSelectorArchivo
            // 
            btnSelectorArchivo.BackColor = Color.FromArgb(13, 51, 70);
            btnSelectorArchivo.Cursor = Cursors.Hand;
            btnSelectorArchivo.FlatAppearance.BorderSize = 0;
            btnSelectorArchivo.FlatStyle = FlatStyle.Flat;
            btnSelectorArchivo.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectorArchivo.ForeColor = Color.White;
            btnSelectorArchivo.Location = new Point(49, 126);
            btnSelectorArchivo.Name = "btnSelectorArchivo";
            btnSelectorArchivo.Size = new Size(244, 42);
            btnSelectorArchivo.TabIndex = 11;
            btnSelectorArchivo.Text = "Seleccionar Archivo";
            btnSelectorArchivo.UseVisualStyleBackColor = false;
            btnSelectorArchivo.Click += btnSelectorArchivo_Click;
            // 
            // txtRuta
            // 
            txtRuta.Enabled = false;
            txtRuta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRuta.Location = new Point(49, 184);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(244, 29);
            txtRuta.TabIndex = 12;
            // 
            // grpTipoGuardado
            // 
            grpTipoGuardado.Controls.Add(rdbAgregar);
            grpTipoGuardado.Controls.Add(rdbSobreescribir);
            grpTipoGuardado.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpTipoGuardado.ForeColor = Color.FromArgb(13, 51, 70);
            grpTipoGuardado.Location = new Point(362, 113);
            grpTipoGuardado.Name = "grpTipoGuardado";
            grpTipoGuardado.Size = new Size(216, 88);
            grpTipoGuardado.TabIndex = 13;
            grpTipoGuardado.TabStop = false;
            grpTipoGuardado.Text = "Tipo de almacenamiento";
            // 
            // rdbAgregar
            // 
            rdbAgregar.AutoSize = true;
            rdbAgregar.Cursor = Cursors.Hand;
            rdbAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdbAgregar.Location = new Point(132, 41);
            rdbAgregar.Name = "rdbAgregar";
            rdbAgregar.Size = new Size(67, 19);
            rdbAgregar.TabIndex = 1;
            rdbAgregar.TabStop = true;
            rdbAgregar.Text = "Agregar";
            rdbAgregar.UseVisualStyleBackColor = true;
            // 
            // rdbSobreescribir
            // 
            rdbSobreescribir.AutoSize = true;
            rdbSobreescribir.Cursor = Cursors.Hand;
            rdbSobreescribir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSobreescribir.Location = new Point(10, 41);
            rdbSobreescribir.Name = "rdbSobreescribir";
            rdbSobreescribir.Size = new Size(93, 19);
            rdbSobreescribir.TabIndex = 0;
            rdbSobreescribir.TabStop = true;
            rdbSobreescribir.Text = "Sobreescribir";
            rdbSobreescribir.UseVisualStyleBackColor = true;
            // 
            // grpPosiciones
            // 
            grpPosiciones.Controls.Add(txtDni);
            grpPosiciones.Controls.Add(txtPlan);
            grpPosiciones.Controls.Add(txtInterno);
            grpPosiciones.Controls.Add(txtCredencial);
            grpPosiciones.Controls.Add(txtEntidad);
            grpPosiciones.Controls.Add(txtApellido);
            grpPosiciones.Controls.Add(txtNombre);
            grpPosiciones.Controls.Add(lblDni);
            grpPosiciones.Controls.Add(lblPlan);
            grpPosiciones.Controls.Add(lblInterno);
            grpPosiciones.Controls.Add(lblCredencial);
            grpPosiciones.Controls.Add(lblEntidad);
            grpPosiciones.Controls.Add(lblApellido);
            grpPosiciones.Controls.Add(lblNombre);
            grpPosiciones.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            grpPosiciones.ForeColor = Color.FromArgb(13, 51, 70);
            grpPosiciones.Location = new Point(668, 113);
            grpPosiciones.Name = "grpPosiciones";
            grpPosiciones.Size = new Size(200, 267);
            grpPosiciones.TabIndex = 14;
            grpPosiciones.TabStop = false;
            grpPosiciones.Text = "Posiciones";
            // 
            // txtDni
            // 
            txtDni.Cursor = Cursors.SizeNS;
            txtDni.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(156, 229);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(24, 23);
            txtDni.TabIndex = 16;
            // 
            // txtPlan
            // 
            txtPlan.Cursor = Cursors.SizeNS;
            txtPlan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlan.Location = new Point(156, 195);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new Size(24, 23);
            txtPlan.TabIndex = 20;
            // 
            // txtInterno
            // 
            txtInterno.Cursor = Cursors.SizeNS;
            txtInterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtInterno.Location = new Point(156, 163);
            txtInterno.Name = "txtInterno";
            txtInterno.Size = new Size(24, 23);
            txtInterno.TabIndex = 19;
            // 
            // txtCredencial
            // 
            txtCredencial.Cursor = Cursors.SizeNS;
            txtCredencial.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCredencial.Location = new Point(156, 131);
            txtCredencial.Name = "txtCredencial";
            txtCredencial.Size = new Size(24, 23);
            txtCredencial.TabIndex = 18;
            // 
            // txtEntidad
            // 
            txtEntidad.Cursor = Cursors.SizeNS;
            txtEntidad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEntidad.Location = new Point(156, 101);
            txtEntidad.Name = "txtEntidad";
            txtEntidad.Size = new Size(24, 23);
            txtEntidad.TabIndex = 17;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.SizeNS;
            txtApellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(156, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(24, 23);
            txtApellido.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.SizeNS;
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(156, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(24, 23);
            txtNombre.TabIndex = 15;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(17, 228);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 20);
            lblDni.TabIndex = 6;
            lblDni.Text = "Dni";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlan.Location = new Point(17, 194);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(37, 20);
            lblPlan.TabIndex = 5;
            lblPlan.Text = "Plan";
            // 
            // lblInterno
            // 
            lblInterno.AutoSize = true;
            lblInterno.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblInterno.Location = new Point(17, 162);
            lblInterno.Name = "lblInterno";
            lblInterno.Size = new Size(56, 20);
            lblInterno.TabIndex = 4;
            lblInterno.Text = "Interno";
            // 
            // lblCredencial
            // 
            lblCredencial.AutoSize = true;
            lblCredencial.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCredencial.Location = new Point(17, 130);
            lblCredencial.Name = "lblCredencial";
            lblCredencial.Size = new Size(79, 20);
            lblCredencial.TabIndex = 3;
            lblCredencial.Text = "Credencial";
            // 
            // lblEntidad
            // 
            lblEntidad.AutoSize = true;
            lblEntidad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEntidad.Location = new Point(17, 100);
            lblEntidad.Name = "lblEntidad";
            lblEntidad.Size = new Size(60, 20);
            lblEntidad.TabIndex = 2;
            lblEntidad.Text = "Entidad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(17, 68);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(17, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(21, 82, 113);
            btnCargar.Cursor = Cursors.Hand;
            btnCargar.FlatAppearance.BorderSize = 0;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(362, 430);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(216, 35);
            btnCargar.TabIndex = 15;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpresa.ForeColor = Color.FromArgb(21, 82, 113);
            lblEmpresa.Location = new Point(128, 270);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(82, 25);
            lblEmpresa.TabIndex = 16;
            lblEmpresa.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.Cursor = Cursors.Hand;
            cmbEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpresa.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(49, 308);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(244, 28);
            cmbEmpresa.TabIndex = 17;
            // 
            // FormCargaDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 527);
            Controls.Add(cmbEmpresa);
            Controls.Add(lblEmpresa);
            Controls.Add(btnCargar);
            Controls.Add(grpPosiciones);
            Controls.Add(grpTipoGuardado);
            Controls.Add(txtRuta);
            Controls.Add(btnSelectorArchivo);
            Controls.Add(btnVolver);
            Controls.Add(lblConfiguracion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCargaDatos";
            Text = "FormConfiguraciones";
            Load += FormCargaDatos_Load;
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            grpTipoGuardado.ResumeLayout(false);
            grpTipoGuardado.PerformLayout();
            grpPosiciones.ResumeLayout(false);
            grpPosiciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfiguracion;
        private PictureBox btnVolver;
        private Button btnSelectorArchivo;
        private TextBox txtRuta;
        private GroupBox grpTipoGuardado;
        private GroupBox grpPosiciones;
        private Label lblNombre;
        private Label lblPlan;
        private Label lblInterno;
        private Label lblCredencial;
        private Label lblEntidad;
        private Label lblApellido;
        private Label lblDni;
        private TextBox txtNombre;
        private TextBox txtDni;
        private TextBox txtPlan;
        private TextBox txtInterno;
        private TextBox txtCredencial;
        private TextBox txtEntidad;
        private TextBox txtApellido;
        private RadioButton rdbAgregar;
        private RadioButton rdbSobreescribir;
        private Button btnCargar;
        private Label lblEmpresa;
        private ComboBox cmbEmpresa;
    }
}