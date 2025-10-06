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

        private void ejercicio1GestiónDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario frm = new FrmInventario();
            frm.ShowDialog();
        }

        private void ejercicio2ListaDeTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTareas frm = new FrmTareas();
            frm.ShowDialog();
        }

        private void ejercicio3CalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalificaciones frm = new FrmCalificaciones();
            frm.ShowDialog();
        }
    }
}
