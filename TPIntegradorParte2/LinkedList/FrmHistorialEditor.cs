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
    public partial class FrmHistorialEditor : Form
    {
        private LinkedList<string> historial = new();
        private LinkedListNode<string> nodoActual = null;

        public FrmHistorialEditor()
        {
            InitializeComponent();
        }

        private void ActualizarLista()
        {
            lstHistorial.Items.Clear();
            foreach (var accion in historial)
            {
                lstHistorial.Items.Add(accion);
            }
        }

        private void btnAgregarAccion_Click(object sender, EventArgs e)
        {
            string accion = txtAccion.Text.Trim();
            if (string.IsNullOrEmpty(accion))
            {
                MessageBox.Show("Ingrese una acción válida (escribir/borrar).");
                return;
            }

            historial.AddLast(accion);
            nodoActual = historial.Last; 
            txtAccion.Clear();
            ActualizarLista();
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            if (nodoActual != null && nodoActual.Previous != null)
            {
                nodoActual = nodoActual.Previous;
                MessageBox.Show($"Acción actual: {nodoActual.Value}");
            }
            else
            {
                MessageBox.Show("No hay acciones para deshacer.");
            }
        }

        private void btnRehacer_Click(object sender, EventArgs e)
        {
            if (nodoActual != null && nodoActual.Next != null)
            {
                nodoActual = nodoActual.Next;
                MessageBox.Show($"Acción actual: {nodoActual.Value}");
            }
            else
            {
                MessageBox.Show("No hay acciones para rehacer.");
            }
        }
    }
}