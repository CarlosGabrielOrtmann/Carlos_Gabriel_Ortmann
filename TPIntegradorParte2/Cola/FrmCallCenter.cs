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
    public partial class FrmCallCenter : Form
    {
        private Queue<string> llamadas = new();

        public FrmCallCenter()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string numero = txtLlamada.Text.Trim();
            if (string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Ingrese el número de cliente.");
                return;
            }

            llamadas.Enqueue(numero);
            txtLlamada.Clear();
            ActualizarLista();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (llamadas.Count > 0)
            {
                string atendida = llamadas.Dequeue();
                MessageBox.Show($"Llamada atendida: {atendida}");
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("No hay llamadas en espera.");
            }
        }

        private void ActualizarLista()
        {
            lstLlamadas.Items.Clear();
            foreach (var numero in llamadas)
            {
                lstLlamadas.Items.Add(numero);
            }
        }


    }
}
