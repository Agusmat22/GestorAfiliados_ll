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
    public partial class FormAutor : Form
    {
        Form formularioConfiguracion;
        public FormAutor(Form formularioConfiguracion)
        {
            InitializeComponent();
            this.formularioConfiguracion = formularioConfiguracion;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            formularioConfiguracion.Show();
        }
    }
}
