namespace GestorAfiliados_ll
{
    partial class FormBuscador
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscador));
            grpBuscador = new GroupBox();
            btnBuscar = new Button();
            rdbDni = new RadioButton();
            rdbNombre = new RadioButton();
            txtBusqueda = new TextBox();
            rdbCredencial = new RadioButton();
            dgvAfiliados = new DataGridView();
            Entidad = new DataGridViewTextBoxColumn();
            TipoPlan = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            NumeroAfiliado = new DataGridViewTextBoxColumn();
            Interno = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            btnImportarExcel = new PictureBox();
            btnVolver = new PictureBox();
            grpBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAfiliados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnImportarExcel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            SuspendLayout();
            // 
            // grpBuscador
            // 
            grpBuscador.Controls.Add(btnBuscar);
            grpBuscador.Controls.Add(rdbDni);
            grpBuscador.Controls.Add(rdbNombre);
            grpBuscador.Controls.Add(txtBusqueda);
            grpBuscador.Controls.Add(rdbCredencial);
            grpBuscador.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpBuscador.ForeColor = Color.FromArgb(13, 51, 70);
            grpBuscador.Location = new Point(296, 26);
            grpBuscador.Name = "grpBuscador";
            grpBuscador.Size = new Size(297, 172);
            grpBuscador.TabIndex = 0;
            grpBuscador.TabStop = false;
            grpBuscador.Text = "Buscador de afiliados";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(21, 82, 113);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(28, 124);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(242, 30);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // rdbDni
            // 
            rdbDni.AutoSize = true;
            rdbDni.Cursor = Cursors.Hand;
            rdbDni.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbDni.Location = new Point(226, 42);
            rdbDni.Name = "rdbDni";
            rdbDni.Size = new Size(44, 19);
            rdbDni.TabIndex = 3;
            rdbDni.TabStop = true;
            rdbDni.Text = "Dni";
            rdbDni.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            rdbNombre.AutoSize = true;
            rdbNombre.Cursor = Cursors.Hand;
            rdbNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbNombre.Location = new Point(28, 42);
            rdbNombre.Name = "rdbNombre";
            rdbNombre.Size = new Size(69, 19);
            rdbNombre.TabIndex = 1;
            rdbNombre.TabStop = true;
            rdbNombre.Text = "Nombre";
            rdbNombre.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.Location = new Point(28, 84);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(242, 27);
            txtBusqueda.TabIndex = 0;
            txtBusqueda.KeyPress += txtBusqueda_KeyPress;
            // 
            // rdbCredencial
            // 
            rdbCredencial.AutoSize = true;
            rdbCredencial.Cursor = Cursors.Hand;
            rdbCredencial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbCredencial.Location = new Point(122, 42);
            rdbCredencial.Name = "rdbCredencial";
            rdbCredencial.Size = new Size(80, 19);
            rdbCredencial.TabIndex = 2;
            rdbCredencial.TabStop = true;
            rdbCredencial.Text = "Credencial";
            rdbCredencial.UseVisualStyleBackColor = true;
            // 
            // dgvAfiliados
            // 
            dgvAfiliados.AllowUserToAddRows = false;
            dgvAfiliados.AllowUserToDeleteRows = false;
            dgvAfiliados.AllowUserToResizeColumns = false;
            dgvAfiliados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(137, 163, 187);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 77, 116);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvAfiliados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAfiliados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAfiliados.BackgroundColor = Color.FromArgb(179, 198, 216);
            dgvAfiliados.BorderStyle = BorderStyle.None;
            dgvAfiliados.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 51, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 77, 116);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAfiliados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAfiliados.ColumnHeadersHeight = 37;
            dgvAfiliados.Columns.AddRange(new DataGridViewColumn[] { Entidad, TipoPlan, NombreCompleto, NumeroAfiliado, Interno, Dni });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(179, 198, 216);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 77, 116);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAfiliados.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAfiliados.EnableHeadersVisualStyles = false;
            dgvAfiliados.Location = new Point(12, 213);
            dgvAfiliados.Name = "dgvAfiliados";
            dgvAfiliados.RowHeadersVisible = false;
            dgvAfiliados.RowTemplate.Height = 35;
            dgvAfiliados.Size = new Size(871, 302);
            dgvAfiliados.TabIndex = 0;
            // 
            // Entidad
            // 
            Entidad.HeaderText = "ENTIDAD";
            Entidad.Name = "Entidad";
            Entidad.ReadOnly = true;
            Entidad.Width = 115;
            // 
            // TipoPlan
            // 
            TipoPlan.HeaderText = "PLAN";
            TipoPlan.Name = "TipoPlan";
            TipoPlan.ReadOnly = true;
            TipoPlan.Width = 145;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "NOMBRE";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 320;
            // 
            // NumeroAfiliado
            // 
            NumeroAfiliado.HeaderText = "CREDENCIAL";
            NumeroAfiliado.Name = "NumeroAfiliado";
            NumeroAfiliado.ReadOnly = true;
            NumeroAfiliado.Width = 130;
            // 
            // Interno
            // 
            Interno.HeaderText = "INT";
            Interno.Name = "Interno";
            Interno.ReadOnly = true;
            Interno.Width = 50;
            // 
            // Dni
            // 
            Dni.HeaderText = "DNI";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            Dni.Width = 111;
            // 
            // btnImportarExcel
            // 
            btnImportarExcel.Cursor = Cursors.Hand;
            btnImportarExcel.Image = (Image)resources.GetObject("btnImportarExcel.Image");
            btnImportarExcel.Location = new Point(827, 12);
            btnImportarExcel.Name = "btnImportarExcel";
            btnImportarExcel.Size = new Size(56, 46);
            btnImportarExcel.SizeMode = PictureBoxSizeMode.Zoom;
            btnImportarExcel.TabIndex = 1;
            btnImportarExcel.TabStop = false;
            btnImportarExcel.Click += btnImportarExcel_Click;
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
            // FormBuscador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(895, 527);
            Controls.Add(btnVolver);
            Controls.Add(btnImportarExcel);
            Controls.Add(dgvAfiliados);
            Controls.Add(grpBuscador);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBuscador";
            Text = "FormBuscador";
            Load += FormBuscador_Load;
            grpBuscador.ResumeLayout(false);
            grpBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAfiliados).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnImportarExcel).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBuscador;
        private RadioButton rdbDni;
        private RadioButton rdbCredencial;
        private RadioButton rdbNombre;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private DataGridView dgvAfiliados;
        private DataGridViewTextBoxColumn Entidad;
        private DataGridViewTextBoxColumn TipoPlan;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn NumeroAfiliado;
        private DataGridViewTextBoxColumn Interno;
        private DataGridViewTextBoxColumn Dni;
        private PictureBox btnImportarExcel;
        private PictureBox btnVolver;
    }
}