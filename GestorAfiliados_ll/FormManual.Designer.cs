namespace GestorAfiliados_ll
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            lblConfiguracion = new Label();
            btnManual = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnManual).BeginInit();
            SuspendLayout();
            // 
            // lblConfiguracion
            // 
            lblConfiguracion.AutoSize = true;
            lblConfiguracion.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfiguracion.ForeColor = Color.FromArgb(13, 51, 70);
            lblConfiguracion.Location = new Point(419, 61);
            lblConfiguracion.Name = "lblConfiguracion";
            lblConfiguracion.Size = new Size(104, 36);
            lblConfiguracion.TabIndex = 13;
            lblConfiguracion.Text = "Manual";
            // 
            // btnManual
            // 
            btnManual.Cursor = Cursors.Hand;
            btnManual.Image = (Image)resources.GetObject("btnManual.Image");
            btnManual.Location = new Point(341, 44);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(72, 68);
            btnManual.SizeMode = PictureBoxSizeMode.Zoom;
            btnManual.TabIndex = 15;
            btnManual.TabStop = false;
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 527);
            Controls.Add(btnManual);
            Controls.Add(lblConfiguracion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormManual";
            Text = "FormManual";
            ((System.ComponentModel.ISupportInitialize)btnManual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfiguracion;
        private PictureBox btnManual;
    }
}