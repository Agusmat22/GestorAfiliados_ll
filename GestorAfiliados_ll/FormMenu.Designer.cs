namespace GestorAfiliados_ll
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelBarraSuperior = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelMenu = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnConfiguracion = new Button();
            btnRegistrar = new Button();
            btnBuscar = new Button();
            imageList1 = new ImageList(components);
            panelFormulario = new Panel();
            pictureBox2 = new PictureBox();
            panelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.BackColor = Color.FromArgb(22, 91, 125);
            panelBarraSuperior.Controls.Add(pictureBox2);
            panelBarraSuperior.Controls.Add(btnMinimizar);
            panelBarraSuperior.Controls.Add(btnCerrar);
            panelBarraSuperior.Cursor = Cursors.Arrow;
            panelBarraSuperior.Dock = DockStyle.Top;
            panelBarraSuperior.Location = new Point(0, 0);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(1104, 50);
            panelBarraSuperior.TabIndex = 0;
            panelBarraSuperior.MouseMove += panelBarraSuperior_MouseMove;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1010, 9);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(44, 33);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 3;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1048, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(44, 33);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 2;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(13, 51, 70);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnConfiguracion);
            panelMenu.Controls.Add(btnRegistrar);
            panelMenu.Controls.Add(btnBuscar);
            panelMenu.Cursor = Cursors.Default;
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 50);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(209, 527);
            panelMenu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(232, 237, 252);
            label1.Location = new Point(30, 107);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 4;
            label1.Text = "Gestor Afiliados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Cursor = Cursors.Hand;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfiguracion.ForeColor = Color.White;
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(0, 312);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(209, 50);
            btnConfiguracion.TabIndex = 2;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(0, 256);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(209, 50);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(0, 200);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(209, 50);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-minimizar-50.png");
            imageList1.Images.SetKeyName(1, "icons8-cerrar-ventana-50.png");
            // 
            // panelFormulario
            // 
            panelFormulario.Cursor = Cursors.Arrow;
            panelFormulario.Dock = DockStyle.Fill;
            panelFormulario.Location = new Point(209, 50);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(895, 527);
            panelFormulario.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1104, 577);
            Controls.Add(panelFormulario);
            Controls.Add(panelMenu);
            Controls.Add(panelBarraSuperior);
            Cursor = Cursors.SizeNS;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += FormMenu_FormClosing;
            Load += FormMenu_Load;
            panelBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBarraSuperior;
        private Panel panelMenu;
        private ImageList imageList1;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Button btnConfiguracion;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Panel panelFormulario;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}