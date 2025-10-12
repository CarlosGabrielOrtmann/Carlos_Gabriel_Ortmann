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
    public partial class FrmListaEspera : Form
    {
        private LinkedList<string> listaEspera = new();

        public FrmListaEspera()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cliente = txtCliente.Text.Trim();
            if (string.IsNullOrEmpty(cliente))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }

            listaEspera.AddLast(cliente);
            txtCliente.Clear();
            ActualizarLista();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (listaEspera.Count == 0)
            {
                MessageBox.Show("No hay clientes en espera.");
                return;
            }

            string atendido = listaEspera.First.Value;
            listaEspera.RemoveFirst();

            MessageBox.Show($"Cliente atendido: {atendido}");
            ActualizarLista();
        }

        private void btnAbandonar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista.");
                return;
            }

            string cliente = lstClientes.SelectedItem.ToString();
            listaEspera.Remove(cliente);
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lstClientes.Items.Clear();
            foreach (string c in listaEspera)
            {
                lstClientes.Items.Add(c);
            }
        }
    }
}
