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
    public partial class FormCargaDatos : Form
    {
        private Form formularioConfiguracion;
        private GestorEmpresa gestorEmpresa;
        private Empresa empresa;
        private string ruta;
        public FormCargaDatos(Form formularioConfiguracion)
        {
            InitializeComponent();
            this.formularioConfiguracion = formularioConfiguracion;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            formularioConfiguracion.Show();
        }

        private void btnSelectorArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar archivo csv";
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.ruta = openFileDialog.FileName;
                this.txtRuta.Text = this.ruta;

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (this.ruta is not null)
            {
                if (empresa is not null)
                {
                    try
                    {
                        GestorArchivos gestorArchivos = new GestorArchivos();
                        gestorArchivos.Leer(this.ruta, empresa.Posiciones);
                        gestorArchivos.Serializar();

                        if (this.rdbSobreescribir.Checked == true)
                        {
                            gestorArchivos.Guardar();
                        }
                        else
                        {
                            //extiendo la lista para que lo agregue y no sobreescriba
                            gestorArchivos.Pacientes.AddRange(this.gestorEmpresa.Afiliados);
                            gestorArchivos.Guardar(true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Error, Debe seleccionar al menos una empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Error, Seleccione un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCargaDatos_Load(object sender, EventArgs e)
        {
            if (this.gestorEmpresa.Empresas.Count > 0)
            {
                this.cmbEmpresa.DataSource = this.gestorEmpresa.Empresas;
                this.cmbEmpresa.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No hay empresas cargadas");
            }

            this.rdbSobreescribir.Checked = true;
        }
    }
}
