namespace Ejercicio_video_de_windows_form___Clase_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double costo = 0;

            // Limpiar el ListBox antes de agregar los nuevos datos
            lstResumen.Items.Clear();

            lstResumen.Items.Add($"Cliente: {nombre}");

            // Seguro seleccionado
            if (rbBasico.Checked)
            {
                costo += 5000;
                lstResumen.Items.Add("Seguro: Básico (5000)");
            }
            else if (rbTerceros.Checked)
            {
                costo += 7000;
                lstResumen.Items.Add("Seguro: A Terceros (7000)");
            }
            else if (rbTotal.Checked)
            {
                costo += 12000;
                lstResumen.Items.Add("Seguro: Total (12000)");
            }

            // Equipamiento extra
            if (chkAire.Checked)
            {
                costo += 2000;
                lstResumen.Items.Add("+ Aire acondicionado (2000)");
            }

            if (chkAudio.Checked)
            {
                costo += 1500;
                lstResumen.Items.Add("+ Sistema de audio (1500)");
            }

            // Mostrar el costo en el TextBox
            txtCosto.Text = costo.ToString("C");

            lstResumen.Items.Add("-----------------------------");
            lstResumen.Items.Add($"TOTAL: {costo:C}");
        }
    }
}
