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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestorAfiliados_ll
{
    public partial class FormCargaDatos : Form
    {
        private Form formularioConfiguracion;
        private GestorEmpresa gestorEmpresa;
        private Empresa empresa;
        private string ruta;

        //PARA EL SUBPROCESO
        CancellationTokenSource cancellationTokenSource;
        CancellationToken cancellationToken;
        Task task;

        public FormCargaDatos(GestorEmpresa gestorEmpresa, Form formularioConfiguracion)
        {
            InitializeComponent();
            this.formularioConfiguracion = formularioConfiguracion;
            this.gestorEmpresa = gestorEmpresa;
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

        /// <summary>
        /// Carga el archivo csv en sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (this.ruta is not null)
            {
                if (empresa is not null)
                {
                    try
                    {
                        
                        //TODO ESTO HACERLO EN UN HILO SECUNDARIO PARA NO BLOQUEAR EL PRINCIPAL
                        bool flag = false;

                        if (this.rdbAgregar.Checked == true)
                        {//extiende la lista
                            flag = true;
                        }

                        Task.Run(() => this.CargarAfiliados(flag), this.cancellationToken);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        // Ocultar y detener el ProgressBar cuando la tarea esté completa
                        progressBar.Visible = false;
                        progressBar.Style = ProgressBarStyle.Blocks; // Vuelve al estilo de bloques
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
            if (this.gestorEmpresa.Empresas is not null && this.gestorEmpresa.Empresas.Count > 0)
            {
                this.cmbEmpresa.DataSource = this.gestorEmpresa.Empresas;
                this.cmbEmpresa.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No hay empresas cargadas");
            }

            this.rdbSobreescribir.Checked = true;

            this.cancellationTokenSource = new CancellationTokenSource();
            this.cancellationToken = this.cancellationTokenSource.Token;
        }

        //Guardo el item seleccionado
        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.empresa = (Empresa)this.cmbEmpresa.SelectedItem;
        }

        private void CargarAfiliados(bool guardado)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(this.CargarAfiliados,guardado);
            }
            else
            {
         
                GestorArchivos gestorArchivos = new GestorArchivos();

                gestorArchivos.LeerAfiliados(this.ruta, empresa.Posiciones);

                gestorArchivos.SerializarPacientes();

                //extiendo la lista
                if (guardado == false)
                {
                    gestorArchivos.Pacientes.AddRange(this.gestorEmpresa.Afiliados);
                }

                gestorArchivos.Guardar(guardado);

                this.gestorEmpresa.Afiliados = gestorArchivos.Pacientes;
                MessageBox.Show("Termino");

             
            }

            

        }
        
    }
}
