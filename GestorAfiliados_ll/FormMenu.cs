using Entidades;
using System.Runtime.InteropServices;

namespace GestorAfiliados_ll
{
    /// <summary>
    /// Delegado
    /// </summary>
    /// <param name="formularios"></param>
    public delegate void MostrarFormulario(Form formularios);

    public partial class FormMenu : Form
    {
        private Button boton;
        private GestorEmpresa gestorEmpresa;
        private MostrarFormulario mostrarFormulario;

        public FormMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra un formulario dentro del panel y borra el anterior
        /// </summary>
        /// <param name="formulario"></param>
        private void MostrarFormulario(Form formulario)
        {
            //limpia el panel antes de agregar un form
            this.LimpiarPanel();

            // configuro el formulario que se va a mostrar
            formulario.TopLevel = false;

            //agrego el form al panel
            this.panelFormulario.Controls.Add(formulario);

            //le quito el borde al form de maximizar,cerrar y minimizar
            formulario.FormBorderStyle = FormBorderStyle.None;
            //indico que el form se expandira en todo el ancho y largo del panel
            formulario.Dock = DockStyle.Fill;
            //aca muestro el formulario
            formulario.Show();

            formulario.BringToFront();
        }

        /// <summary>
        /// Muestra un formulario encima del que esta abierto.
        /// </summary>
        /// <param name="formulario"></param>
        private void MostrarSubFormulario(Form formulario)
        {
            //limpia el panel antes de agregar un form
            //this.LimpiarPanel();

            // configuro el formulario que se va a mostrar
            formulario.TopLevel = false;

            //agrego el form al panel
            this.panelFormulario.Controls.Add(formulario);

            //le quito el borde al form de maximizar,cerrar y minimizar
            formulario.FormBorderStyle = FormBorderStyle.None;
            //indico que el form se expandira en todo el ancho y largo del panel
            formulario.Dock = DockStyle.Fill;
            //aca muestro el formulario
            formulario.Show();

            formulario.BringToFront();
        }

        /// <summary>
        /// Limpia todos los controles
        /// </summary>
        private void LimpiarPanel()
        {
            this.panelFormulario.Controls.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Uso este evento para mover con el mouse el panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelBarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        /// <summary>
        /// Estos dos metodos los cree para poder mover el formulario, ya que no contiene FormBorder
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Cambiar el color de un boton
        /// </summary>
        /// <param name="boton"></param>
        /// <param name="rojo"></param>
        /// <param name="verde"></param>
        /// <param name="azul"></param>
        private void CambiarColorBoton(Button boton, int rojo, int verde, int azul)
        {
            boton.BackColor = Color.FromArgb(rojo, verde, azul);
        }

        private void CambiarColorBotonPresionado(Button button)
        {
            if (this.boton is not null) //vuelvo al boton presionado anteriormente a su color por defecto
            {
                this.CambiarColorBoton(this.boton, 13, 51, 70);
            }

            button.BackColor = Color.FromArgb(7, 28, 39);  //le asigno el color nuevo al boton presionado ahora
            this.boton = button;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.CambiarColorBotonPresionado(this.btnBuscar);

            this.MostrarFormulario(new FormBuscador(this.gestorEmpresa));

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.CambiarColorBotonPresionado(this.btnRegistrar);

            this.MostrarFormulario(new FormRegistrar(this.gestorEmpresa, this.mostrarFormulario));

        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.CambiarColorBotonPresionado(this.btnConfiguracion);
            FormConfiguracion formConfiguracion = new FormConfiguracion(this.gestorEmpresa, this.mostrarFormulario);
            this.MostrarFormulario(formConfiguracion);
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que deseas cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.mostrarFormulario += this.MostrarSubFormulario;

            //instancio el gestor de empresa quien se encarga de manipular toda la aplicacion
            this.gestorEmpresa = new GestorEmpresa();


            try
            {
                //cargo los afiliados y empresas registrados en sistema
                this.gestorEmpresa.Cargar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}