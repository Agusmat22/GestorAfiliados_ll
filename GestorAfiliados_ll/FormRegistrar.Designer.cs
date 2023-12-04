namespace GestorAfiliados_ll
{
    partial class FormRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrar));
            btnVolver = new PictureBox();
            btnAfiliado = new PictureBox();
            btnEmpresa = new PictureBox();
            lblConfiguracion = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAfiliado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEmpresa).BeginInit();
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
            btnVolver.TabIndex = 9;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAfiliado
            // 
            btnAfiliado.Cursor = Cursors.Hand;
            btnAfiliado.Image = (Image)resources.GetObject("btnAfiliado.Image");
            btnAfiliado.Location = new Point(205, 225);
            btnAfiliado.Name = "btnAfiliado";
            btnAfiliado.Size = new Size(136, 120);
            btnAfiliado.SizeMode = PictureBoxSizeMode.Zoom;
            btnAfiliado.TabIndex = 10;
            btnAfiliado.TabStop = false;
            btnAfiliado.Click += btnAfiliado_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.Cursor = Cursors.Hand;
            btnEmpresa.Image = (Image)resources.GetObject("btnEmpresa.Image");
            btnEmpresa.Location = new Point(559, 225);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Size = new Size(136, 123);
            btnEmpresa.SizeMode = PictureBoxSizeMode.Zoom;
            btnEmpresa.TabIndex = 11;
            btnEmpresa.TabStop = false;
            // 
            // lblConfiguracion
            // 
            lblConfiguracion.AutoSize = true;
            lblConfiguracion.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfiguracion.ForeColor = Color.FromArgb(13, 51, 70);
            lblConfiguracion.Location = new Point(383, 60);
            lblConfiguracion.Name = "lblConfiguracion";
            lblConfiguracion.Size = new Size(126, 37);
            lblConfiguracion.TabIndex = 12;
            lblConfiguracion.Text = "Registrar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(21, 82, 113);
            label1.Location = new Point(233, 186);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 13;
            label1.Text = "Afiliado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(21, 82, 113);
            label2.Location = new Point(585, 186);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 14;
            label2.Text = "Empresa";
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 527);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblConfiguracion);
            Controls.Add(btnEmpresa);
            Controls.Add(btnAfiliado);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrar";
            Text = "FormRegistrar";
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAfiliado).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEmpresa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox btnVolver;
        private PictureBox btnAfiliado;
        private PictureBox btnEmpresa;
        private Label lblConfiguracion;
        private Label label1;
        private Label label2;
    }
}