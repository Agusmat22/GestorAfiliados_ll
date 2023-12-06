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
    public partial class FormBuscador : Form
    {
        private GestorEmpresa gestorEmpresa;
        private List<Paciente> pacientesEncontrados;
        public FormBuscador(GestorEmpresa gestorEmpresa)
        {
            InitializeComponent();
            this.gestorEmpresa = gestorEmpresa;
            this.pacientesEncontrados = new List<Paciente>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            string textoIngresado = this.txtBusqueda.Text.Trim();


            if (Regex.IsMatch(textoIngresado, @"^([0-9]+|[a-zA-Z\s]+)$"))
            {
                foreach (Control item in this.grpBuscador.Controls)
                {
                    if (item is RadioButton rdb && rdb.Checked == true)
                    {
                        if (rdb == this.rdbDni)
                        {
                            this.pacientesEncontrados = gestorEmpresa.ObtenerAfiliadosPorDni(textoIngresado);
                        }
                        else if (rdb == this.rdbCredencial)
                        {
                            this.pacientesEncontrados = gestorEmpresa.ObtenerAfiliadosPorCredencial(textoIngresado);
                        }
                        else
                        {
                            this.pacientesEncontrados = gestorEmpresa.ObtenerAfiliadosPorNombre(textoIngresado);
                        }

                        this.CargarAfiliadosDataGridView(this.pacientesEncontrados.Take(15).ToList());
                        break;
                    }
                }
            }
            else
            {
                //limpio el dataGrid
                this.dgvAfiliados.Rows.Clear();
            }

            this.txtBusqueda.Text = "";


        }

        private void FormBuscador_Load(object sender, EventArgs e)
        {
            //selecciono un radioButton por defecto
            this.rdbCredencial.Checked = true;
            this.dgvAfiliados.ScrollBars = ScrollBars.Vertical; // Solo mostrará la barra de desplazamiento vertical

            dgvAfiliados.AllowUserToResizeColumns = false;



        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //simulo el click al boton buscar
                this.btnBuscar.PerformClick();
            }
        }

        /// <summary>
        /// Carga una lista de afiliados en el dataGridView segun corresponda en cada columna
        /// </summary>
        /// <param name="lista"></param>
        private void CargarAfiliadosDataGridView(List<Paciente> lista)
        {
            //limpio el dataGrid
            this.dgvAfiliados.Rows.Clear();

            foreach (Paciente af in lista)
            {
                int rowIndex = this.dgvAfiliados.Rows.Add();
                this.dgvAfiliados.Rows[rowIndex].Cells["Entidad"].Value = af.Entidad;
                this.dgvAfiliados.Rows[rowIndex].Cells["TipoPlan"].Value = af.Plan;
                this.dgvAfiliados.Rows[rowIndex].Cells["NombreCompleto"].Value = af.ToString();
                this.dgvAfiliados.Rows[rowIndex].Cells["NumeroAfiliado"].Value = af.Credencial;
                this.dgvAfiliados.Rows[rowIndex].Cells["Interno"].Value = af.Interno;
                this.dgvAfiliados.Rows[rowIndex].Cells["Dni"].Value = af.Dni;
            }

            this.dgvAfiliados.ClearSelection();
        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();


            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //SEGUIR EL CODIGO MANIANA

            }
            else
            {
                MessageBox.Show("Importacion cancelada", "Cancelado");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
