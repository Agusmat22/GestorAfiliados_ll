namespace GestorAfiliados_ll
{
    partial class FormRegistrarEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarEmpresa));
            btnCancelar = new Button();
            btnRegistrar = new Button();
            grpRegistro = new GroupBox();
            lblPlan = new Label();
            lblInterno = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblEntidad = new Label();
            lblCredencial = new Label();
            lblNombre = new Label();
            txtDni = new TextBox();
            txtPlan = new TextBox();
            txtInterno = new TextBox();
            txtApellido = new TextBox();
            txtEntidad = new TextBox();
            txtCredencial = new TextBox();
            txtNombre = new TextBox();
            btnVolver = new PictureBox();
            txtEmpresa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(158, 444);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 36);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(21, 82, 113);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(526, 444);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(206, 36);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // grpRegistro
            // 
            grpRegistro.Controls.Add(label2);
            grpRegistro.Controls.Add(label1);
            grpRegistro.Controls.Add(txtEmpresa);
            grpRegistro.Controls.Add(lblPlan);
            grpRegistro.Controls.Add(lblInterno);
            grpRegistro.Controls.Add(lblApellido);
            grpRegistro.Controls.Add(lblDni);
            grpRegistro.Controls.Add(lblEntidad);
            grpRegistro.Controls.Add(lblCredencial);
            grpRegistro.Controls.Add(lblNombre);
            grpRegistro.Controls.Add(txtDni);
            grpRegistro.Controls.Add(txtPlan);
            grpRegistro.Controls.Add(txtInterno);
            grpRegistro.Controls.Add(txtApellido);
            grpRegistro.Controls.Add(txtEntidad);
            grpRegistro.Controls.Add(txtCredencial);
            grpRegistro.Controls.Add(txtNombre);
            grpRegistro.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            grpRegistro.ForeColor = Color.FromArgb(13, 51, 70);
            grpRegistro.Location = new Point(158, 49);
            grpRegistro.Name = "grpRegistro";
            grpRegistro.Size = new Size(574, 378);
            grpRegistro.TabIndex = 13;
            grpRegistro.TabStop = false;
            grpRegistro.Text = "Registrar Empresa";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlan.Location = new Point(309, 284);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(36, 19);
            lblPlan.TabIndex = 13;
            lblPlan.Text = "Plan";
            // 
            // lblInterno
            // 
            lblInterno.AutoSize = true;
            lblInterno.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblInterno.Location = new Point(309, 239);
            lblInterno.Name = "lblInterno";
            lblInterno.Size = new Size(54, 19);
            lblInterno.TabIndex = 12;
            lblInterno.Text = "Interno";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(309, 194);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(61, 19);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(131, 328);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(31, 19);
            lblDni.TabIndex = 10;
            lblDni.Text = "Dni";
            // 
            // lblEntidad
            // 
            lblEntidad.AutoSize = true;
            lblEntidad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEntidad.Location = new Point(131, 284);
            lblEntidad.Name = "lblEntidad";
            lblEntidad.Size = new Size(56, 19);
            lblEntidad.TabIndex = 9;
            lblEntidad.Text = "Entidad";
            // 
            // lblCredencial
            // 
            lblCredencial.AutoSize = true;
            lblCredencial.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCredencial.Location = new Point(131, 239);
            lblCredencial.Name = "lblCredencial";
            lblCredencial.Size = new Size(75, 19);
            lblCredencial.TabIndex = 8;
            lblCredencial.Text = "Credencial";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(131, 194);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 19);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // txtDni
            // 
            txtDni.Cursor = Cursors.IBeam;
            txtDni.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtDni.Location = new Point(221, 319);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(34, 32);
            txtDni.TabIndex = 6;
            // 
            // txtPlan
            // 
            txtPlan.Cursor = Cursors.IBeam;
            txtPlan.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtPlan.Location = new Point(394, 275);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new Size(34, 32);
            txtPlan.TabIndex = 5;
            // 
            // txtInterno
            // 
            txtInterno.Cursor = Cursors.IBeam;
            txtInterno.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtInterno.Location = new Point(394, 230);
            txtInterno.Name = "txtInterno";
            txtInterno.Size = new Size(34, 32);
            txtInterno.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(394, 185);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(34, 32);
            txtApellido.TabIndex = 3;
            // 
            // txtEntidad
            // 
            txtEntidad.Cursor = Cursors.IBeam;
            txtEntidad.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtEntidad.Location = new Point(221, 275);
            txtEntidad.Name = "txtEntidad";
            txtEntidad.Size = new Size(34, 32);
            txtEntidad.TabIndex = 2;
            // 
            // txtCredencial
            // 
            txtCredencial.Cursor = Cursors.IBeam;
            txtCredencial.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtCredencial.Location = new Point(221, 230);
            txtCredencial.Name = "txtCredencial";
            txtCredencial.Size = new Size(34, 32);
            txtCredencial.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(221, 185);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(34, 32);
            txtNombre.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(42, 40);
            btnVolver.SizeMode = PictureBoxSizeMode.Zoom;
            btnVolver.TabIndex = 16;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Cursor = Cursors.IBeam;
            txtEmpresa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmpresa.Location = new Point(131, 76);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(297, 32);
            txtEmpresa.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 52);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 15;
            label1.Text = "Nombre de empresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(243, 137);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 16;
            label2.Text = "Posicion";
            // 
            // FormRegistrarEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 527);
            Controls.Add(btnVolver);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(grpRegistro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrarEmpresa";
            Text = "FormRegistrarEmpresa";
            grpRegistro.ResumeLayout(false);
            grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnRegistrar;
        private GroupBox grpRegistro;
        private Label lblPlan;
        private Label lblInterno;
        private Label lblApellido;
        private Label lblDni;
        private Label lblEntidad;
        private Label lblCredencial;
        private Label lblNombre;
        private TextBox txtDni;
        private TextBox txtPlan;
        private TextBox txtInterno;
        private TextBox txtApellido;
        private TextBox txtEntidad;
        private TextBox txtCredencial;
        private TextBox txtNombre;
        private PictureBox btnVolver;
        private Label label1;
        private TextBox txtEmpresa;
        private Label label2;
    }
}