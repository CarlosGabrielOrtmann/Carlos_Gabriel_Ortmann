using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIntegradorParte2
{
    public partial class FrmHistorialNavegacion : Form
    {
        private Stack<string> historial = new();

        public FrmHistorialNavegacion()
        {
            InitializeComponent();
        }

        private void btnVisitar_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Ingrese una URL válida.");
                return;
            }

            historial.Push(url);
            txtUrl.Clear();
            ActualizarLista();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (historial.Count > 0)
            {
                string ultimaPagina = historial.Pop();
                MessageBox.Show($"Página anterior: {ultimaPagina}");
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("No hay historial de navegación.");
            }
        }

        private void ActualizarLista()
        {
            lstHistorial.Items.Clear();
            foreach (var url in historial)
            {
                lstHistorial.Items.Add(url);
            }
        }
    }
}
