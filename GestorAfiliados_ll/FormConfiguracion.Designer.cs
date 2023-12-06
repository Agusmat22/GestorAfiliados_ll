namespace GestorAfiliados_ll
{
    partial class FormConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
            btnVolver = new PictureBox();
            lblConfiguracion = new Label();
            btnCargarArchivo = new PictureBox();
            btnDerechosAutor = new PictureBox();
            btnManual = new PictureBox();
            lblCargar = new Label();
            lblManual = new Label();
            lblCopyright = new Label();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCargarArchivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDerechosAutor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnManual).BeginInit();
            SuspendLayout();
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
            // lblConfiguracion
            // 
            lblConfiguracion.AutoSize = true;
            lblConfiguracion.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfiguracion.ForeColor = Color.FromArgb(13, 51, 70);
            lblConfiguracion.Location = new Point(361, 32);
            lblConfiguracion.Name = "lblConfiguracion";
            lblConfiguracion.Size = new Size(183, 36);
            lblConfiguracion.TabIndex = 11;
            lblConfiguracion.Text = "Configuracion";
            // 
            // btnCargarArchivo
            // 
            btnCargarArchivo.Cursor = Cursors.Hand;
            btnCargarArchivo.Image = (Image)resources.GetObject("btnCargarArchivo.Image");
            btnCargarArchivo.Location = new Point(140, 217);
            btnCargarArchivo.Name = "btnCargarArchivo";
            btnCargarArchivo.Size = new Size(124, 106);
            btnCargarArchivo.SizeMode = PictureBoxSizeMode.Zoom;
            btnCargarArchivo.TabIndex = 12;
            btnCargarArchivo.TabStop = false;
            btnCargarArchivo.Click += btnCargarArchivo_Click;
            // 
            // btnDerechosAutor
            // 
            btnDerechosAutor.Cursor = Cursors.Hand;
            btnDerechosAutor.Image = (Image)resources.GetObject("btnDerechosAutor.Image");
            btnDerechosAutor.Location = new Point(638, 217);
            btnDerechosAutor.Name = "btnDerechosAutor";
            btnDerechosAutor.Size = new Size(124, 106);
            btnDerechosAutor.SizeMode = PictureBoxSizeMode.Zoom;
            btnDerechosAutor.TabIndex = 13;
            btnDerechosAutor.TabStop = false;
            btnDerechosAutor.Click += btnDerechosAutor_Click;
            // 
            // btnManual
            // 
            btnManual.Cursor = Cursors.Hand;
            btnManual.Image = (Image)resources.GetObject("btnManual.Image");
            btnManual.Location = new Point(390, 217);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(124, 106);
            btnManual.SizeMode = PictureBoxSizeMode.Zoom;
            btnManual.TabIndex = 14;
            btnManual.TabStop = false;
            // 
            // lblCargar
            // 
            lblCargar.AutoSize = true;
            lblCargar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargar.ForeColor = Color.FromArgb(21, 82, 113);
            lblCargar.Location = new Point(169, 189);
            lblCargar.Name = "lblCargar";
            lblCargar.Size = new Size(69, 25);
            lblCargar.TabIndex = 15;
            lblCargar.Text = "Cargar";
            // 
            // lblManual
            // 
            lblManual.AutoSize = true;
            lblManual.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblManual.ForeColor = Color.FromArgb(21, 82, 113);
            lblManual.Location = new Point(414, 189);
            lblManual.Name = "lblManual";
            lblManual.Size = new Size(77, 25);
            lblManual.TabIndex = 16;
            lblManual.Text = "Manual";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCopyright.ForeColor = Color.FromArgb(21, 82, 113);
            lblCopyright.Location = new Point(653, 189);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(97, 25);
            lblCopyright.TabIndex = 17;
            lblCopyright.Text = "Copyright";
            // 
            // FormConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 527);
            Controls.Add(lblCopyright);
            Controls.Add(lblManual);
            Controls.Add(lblCargar);
            Controls.Add(btnManual);
            Controls.Add(btnDerechosAutor);
            Controls.Add(btnCargarArchivo);
            Controls.Add(lblConfiguracion);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConfiguracion";
            Text = "FormConfiguracion";
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCargarArchivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDerechosAutor).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnManual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnVolver;
        private Label lblConfiguracion;
        private PictureBox btnCargarArchivo;
        private PictureBox btnDerechosAutor;
        private PictureBox btnManual;
        private Label lblCargar;
        private Label lblManual;
        private Label lblCopyright;
    }
}