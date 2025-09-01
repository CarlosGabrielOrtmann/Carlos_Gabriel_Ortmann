namespace Ejemplo_de_creación_de_otro_form_mediante_un_botón_en_otro_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //Form2 miforma = new Form2();
            Form2 miforma = new Form2(txtMensaje.Text);

            //miforma.Show();
            miforma.ShowDialog();
        }
    }
}
