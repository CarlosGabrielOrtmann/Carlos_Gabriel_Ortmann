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
    public partial class FrmPilaPlatos : Form
    {
        private Stack<string> pila = new();

        public FrmPilaPlatos()
        {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            string plato = txtPlato.Text.Trim();
            if (string.IsNullOrEmpty(plato))
            {
                MessageBox.Show("Ingrese un nombre de plato válido.");
                return;
            }

            pila.Push(plato);
            txtPlato.Clear();
            ActualizarLista();
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                string desapilado = pila.Pop();
                MessageBox.Show($"Plato desapilado: {desapilado}");
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void btnVercima_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                MessageBox.Show($"Plato en la cima: {pila.Peek()}");
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void ActualizarLista()
        {
            lstPlatos.Items.Clear();
            foreach (var plato in pila)
            {
                lstPlatos.Items.Add(plato);
            }
        }
    }
}
