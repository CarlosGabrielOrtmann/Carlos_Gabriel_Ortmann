namespace WinFormsApp2
{
    public partial class frmEjercicio01 : Form
    {
        public frmEjercicio01()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblSalida.Text = txtNombre.Text + " " + txtApellido.Text;

        }
    }
}
