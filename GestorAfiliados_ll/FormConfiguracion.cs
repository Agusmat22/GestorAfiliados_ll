using Entidades;
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
        private GestorEmpresa gestorEmpresa;
        public FormConfiguracion(GestorEmpresa gestorEmpresa, MostrarFormulario mostrarFormulario)
        {
            InitializeComponent();
            this.mostrarFormulario = mostrarFormulario;
            this.gestorEmpresa = gestorEmpresa;
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            FormCargaDatos formCargaDatos = new FormCargaDatos(gestorEmpresa, this);
            this.Hide();
            this.mostrarFormulario(formCargaDatos);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDerechosAutor_Click(object sender, EventArgs e)
        {
            FormAutor formAutor = new FormAutor(this);
            this.Hide();
            this.mostrarFormulario(formAutor);
        }
    }
}
