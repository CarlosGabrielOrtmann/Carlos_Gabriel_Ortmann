namespace TPIntegradorParte2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void autoresDelTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carlos Gabriel Ortmann");
        }
    }
}
