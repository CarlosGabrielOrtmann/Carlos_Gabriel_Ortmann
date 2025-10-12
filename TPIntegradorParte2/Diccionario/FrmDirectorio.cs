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
    public partial class FrmDirectorio : Form
    {
        private Dictionary<string, string> agenda = new();

        public FrmDirectorio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Ingrese nombre y teléfono.");
                return;
            }

            agenda[nombre] = telefono;
            txtNombre.Clear();
            txtTelefono.Clear();
            ActualizarLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (agenda.ContainsKey(nombre))
            {
                MessageBox.Show($"Teléfono de {nombre}: {agenda[nombre]}");
            }
            else
            {
                MessageBox.Show("Contacto no encontrado.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (agenda.Remove(nombre))
            {
                MessageBox.Show("Contacto eliminado.");
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Contacto no encontrado.");
            }
        }

        private void ActualizarLista()
        {
            lstContactos.Items.Clear();
            foreach (var c in agenda)
            {
                lstContactos.Items.Add($"{c.Key}: {c.Value}");
            }
        }
    }
}
