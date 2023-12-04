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
        public FormRegistrar(GestorEmpresa gestorEmpresa)
        {
            InitializeComponent();
            this.gestorEmpresa = gestorEmpresa;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z]+$"))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z]+$"))
            {
                e.Handled = true;
            }
        }

        private void txtCredencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^[0-9]+$"))
            {
                e.Handled = true;
            }
        }

        private void txtInterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^[0-9]+$"))
            {
                e.Handled = true;
            }
        }

        private void txtEntidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z]+$"))
            {
                e.Handled = true;
            }
        }

        private void txtPlan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z]*|[0-9]+$"))
            {
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^[0-9]+$"))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string credencial;
            string interno;
            string plan;
            string dni;
            string entidad;

            bool flag = true;


            foreach (Control item in this.grpRegistro.Controls)
            {
                if (item is TextBox txt && txt.Text != string.Empty)
                {
                    if (txt == this.txtNombre)
                    {
                        nombre = txt.Text;
                    }
                    else if(txt == this.txtApellido)
                    {
                        apellido = txt.Text;
                    }
                    else if (txt == this.txtCredencial)
                    {
                        credencial = txt.Text;
                    }
                    else if (txt == this.txtInterno)
                    {
                        interno = txt.Text;
                    }
                    else if (txt == this.txtPlan)
                    {
                        plan = txt.Text;
                    }
                    else if (txt == this.txtDni)
                    {
                        dni = txt.Text;
                    }
                    else
                    {
                        entidad = txt.Text;
                    }
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
                
            
            }

        }
    }
}
