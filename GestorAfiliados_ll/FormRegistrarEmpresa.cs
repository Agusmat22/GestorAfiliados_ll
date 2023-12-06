using Entidades;
using Entidades.Excepciones;
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
    public partial class FormRegistrarEmpresa : Form
    {
        private Form formularioRegistro;
        private GestorEmpresa gestorEmpresa;
        public FormRegistrarEmpresa(GestorEmpresa gestorEmpresa, Form formuarioRegistro)
        {
            InitializeComponent();
            this.formularioRegistro = formuarioRegistro;
            this.gestorEmpresa = gestorEmpresa;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int nombre = 0;
            int apellido = 0;
            int credencial = 0;
            int plan = 0;
            int dni = 0;
            int entidad = 0;
            int interno = 0;

            string nombreEmpresa = "";

            bool flag = true;


            foreach (Control item in this.grpRegistro.Controls)
            {
                if (item is TextBox txt && txt.Text != string.Empty)
                {
                    if (txt == this.txtNombre)
                    {
                        int.TryParse(txt.Text, out nombre);
                    }
                    else if (txt == this.txtApellido)
                    {
                        int.TryParse(txt.Text, out apellido);
                    }
                    else if (txt == this.txtCredencial)
                    {
                        int.TryParse(txt.Text, out credencial);
                    }
                    else if (txt == this.txtInterno)
                    {
                        int.TryParse(txt.Text, out interno);
                    }
                    else if (txt == this.txtPlan)
                    {
                        int.TryParse(txt.Text, out plan);
                    }
                    else if (txt == this.txtDni)
                    {
                        int.TryParse(txt.Text, out dni);
                    }
                    else if(txt == this.txtEntidad)
                    {
                        int.TryParse(txt.Text, out entidad);
                    }
                    else
                    {
                        //NOMBRE DE LA EMPRESA
                        nombreEmpresa = txt.Text;

                    }
                }
                else if(item is Label)
                {
                    continue;
                }
                else
                {

                    MessageBox.Show("Error, debe completar todos los campos del registro");
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                try
                {
                    int[] posiciones = new int[] { nombre,apellido,dni,entidad,plan,credencial,interno};

                    //ÀPLICAR LA LOGICA PARA GUARDARLO
                    if (this.gestorEmpresa.AgregarEmpresa(new Empresa(nombreEmpresa, posiciones)))
                    {
                        MessageBox.Show("Registro exitoso");
                    }
                    else
                    {
                        MessageBox.Show("El afiliado ya se encuentra registrado");
                    }
                }
                catch (PropiedadNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formularioRegistro.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formularioRegistro.Show();
        }
    }
}
