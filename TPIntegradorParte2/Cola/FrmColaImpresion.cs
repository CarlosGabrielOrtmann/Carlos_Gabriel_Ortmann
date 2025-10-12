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
    public partial class FrmColaImpresion : Form
    {
        private Queue<string> cola = new();

        public FrmColaImpresion()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string doc = txtDocumento.Text.Trim();
            if (string.IsNullOrEmpty(doc))
            {
                MessageBox.Show("Ingrese el nombre del documento.");
                return;
            }

            cola.Enqueue(doc);
            txtDocumento.Clear();
            ActualizarLista();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cola.Count > 0)
            {
                string docImpreso = cola.Dequeue();
                MessageBox.Show($"Documento impreso: {docImpreso}");
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("No hay documentos en la cola.");
            }
        }

        private void ActualizarLista()
        {
            lstDocumentos.Items.Clear();
            foreach (var doc in cola)
            {
                lstDocumentos.Items.Add(doc);
            }
        }
    }
}
