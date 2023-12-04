using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorAfiliados_ll
{
    public partial class FormConfiguracion : Form
    {
        private MostrarFormulario mostrarFormulario;
        public FormConfiguracion(MostrarFormulario mostrarFormulario)
        {
            InitializeComponent();
            this.mostrarFormulario = mostrarFormulario;
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            FormCargaDatos formCargaDatos = new FormCargaDatos(this);
            this.Hide();
            this.mostrarFormulario(formCargaDatos);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
