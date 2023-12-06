using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorAfiliados_ll
{
    public partial class FormRegistrar : Form
    {
        private GestorEmpresa gestorEmpresa;
        private MostrarFormulario mostrarFormulario;

        public FormRegistrar(GestorEmpresa gestorEmpresa, MostrarFormulario mostrarFormulario)
        {
            InitializeComponent();
            this.gestorEmpresa = gestorEmpresa;
            this.mostrarFormulario = mostrarFormulario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAfiliado_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario(this.gestorEmpresa, this);
            this.Hide();
            this.mostrarFormulario(formRegistrarUsuario);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FormRegistrarEmpresa formRegistrarEmpresa = new FormRegistrarEmpresa(this.gestorEmpresa, this);
            this.Hide();
            this.mostrarFormulario(formRegistrarEmpresa);
        }
    }
}
