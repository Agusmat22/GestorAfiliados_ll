namespace GestorAfiliados_ll
{
    partial class FormAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutor));
            lblConfiguracion = new Label();
            btnDerechosAutor = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLinkedin = new PictureBox();
            btnVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnDerechosAutor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLinkedin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            SuspendLayout();
            // 
            // lblConfiguracion
            // 
            lblConfiguracion.AutoSize = true;
            lblConfiguracion.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfiguracion.ForeColor = Color.FromArgb(13, 51, 70);
            lblConfiguracion.Location = new Point(366, 57);
            lblConfiguracion.Name = "lblConfiguracion";
            lblConfiguracion.Size = new Size(234, 36);
            lblConfiguracion.TabIndex = 12;
            lblConfiguracion.Text = "Derechos de autor";
            // 
            // btnDerechosAutor
            // 
            btnDerechosAutor.Cursor = Cursors.Hand;
            btnDerechosAutor.Image = (Image)resources.GetObject("btnDerechosAutor.Image");
            btnDerechosAutor.Location = new Point(290, 48);
            btnDerechosAutor.Name = "btnDerechosAutor";
            btnDerechosAutor.Size = new Size(70, 56);
            btnDerechosAutor.SizeMode = PictureBoxSizeMode.Zoom;
            btnDerechosAutor.TabIndex = 14;
            btnDerechosAutor.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(21, 82, 113);
            label2.Location = new Point(131, 201);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 15;
            label2.Text = "Creador:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(21, 82, 113);
            label1.Location = new Point(131, 290);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 16;
            label1.Text = "Fecha de actualizacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(21, 82, 113);
            label3.Location = new Point(131, 386);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 17;
            label3.Text = "Contacto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(237, 201);
            label4.Name = "label4";
            label4.Size = new Size(195, 25);
            label4.TabIndex = 18;
            label4.Text = "Agustin Garcia Navas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(347, 290);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 19;
            label5.Text = "10/12/2023";
            // 
            // btnLinkedin
            // 
            btnLinkedin.Image = (Image)resources.GetObject("btnLinkedin.Image");
            btnLinkedin.Location = new Point(237, 374);
            btnLinkedin.Name = "btnLinkedin";
            btnLinkedin.Size = new Size(43, 49);
            btnLinkedin.SizeMode = PictureBoxSizeMode.Zoom;
            btnLinkedin.TabIndex = 20;
            btnLinkedin.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(42, 40);
            btnVolver.SizeMode = PictureBoxSizeMode.Zoom;
            btnVolver.TabIndex = 21;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 527);
            Controls.Add(btnVolver);
            Controls.Add(btnLinkedin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnDerechosAutor);
            Controls.Add(lblConfiguracion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAutor";
            Text = "FormAutor";
            ((System.ComponentModel.ISupportInitialize)btnDerechosAutor).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLinkedin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfiguracion;
        private PictureBox btnDerechosAutor;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox btnLinkedin;
        private PictureBox btnVolver;
    }
}