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

        private void ejercicio1ListaDeEsperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaEspera frm = new FrmListaEspera();
            frm.ShowDialog();
        }

        private void ejercicio2ListaDeTareasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHistorialEditor frm = new FrmHistorialEditor();
            frm.ShowDialog();
        }

        private void ejercicio3CalificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPlaylist frm = new FrmPlaylist();
            frm.ShowDialog();
        }

        private void simuladorPilaDePlatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPilaPlatos frm = new FrmPilaPlatos();
            frm.ShowDialog();
        }

        private void ej2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParentesis frm = new FrmParentesis();
            frm.ShowDialog();
        }

        private void ej3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorialNavegacion frm = new FrmHistorialNavegacion();
            frm.ShowDialog();
        }

        private void ej1ImToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColaImpresion frm = new FrmColaImpresion();
            frm.ShowDialog();
        }

        private void ej2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCallCenter frm = new FrmCallCenter();
            frm.ShowDialog();
        }

        private void ej3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmColaProcesos frm = new FrmColaProcesos();
            frm.ShowDialog();
        }

        private void ej1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDirectorio frm = new FrmDirectorio();
            frm.ShowDialog();
        }

        private void ej2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCatalogo frm = new FrmCatalogo();
            frm.ShowDialog();
        }

        private void ej3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTraductor frm = new FrmTraductor();
            frm.ShowDialog();
        }
    }
}
