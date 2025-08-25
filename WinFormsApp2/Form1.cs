namespace WinFormsApp2
{
    public partial class frmEjercicio01 : Form
    {
        List<string> listanombres = new List<string>();

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
            //float numero = 20;
            lblSalida.Text = txtNombre.Text + " " + txtApellido.Text;
            //lbl_texto.txt = numero.ToString();
            string nombre;
            nombre = lblSalida.Text;
            listanombres.Add(nombre);
            list_nombres.DataSource = null;
            list_nombres.DataSource = listanombres;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
