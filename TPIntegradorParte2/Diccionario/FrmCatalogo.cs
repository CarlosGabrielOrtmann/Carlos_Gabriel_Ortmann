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
    public partial class FrmCatalogo : Form
    {
        private Dictionary<string, string> catalogo = new();

        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string sku = txtSku.Text.Trim();
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(sku) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese código SKU y nombre del producto.");
                return;
            }

            catalogo[sku] = nombre;
            txtSku.Clear();
            txtNombre.Clear();
            ActualizarLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sku = txtSku.Text.Trim();
            if (catalogo.ContainsKey(sku))
            {
                MessageBox.Show($"Producto: {catalogo[sku]}");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void ActualizarLista()
        {
            lstProductos.Items.Clear();
            foreach (var item in catalogo)
            {
                lstProductos.Items.Add($"{item.Key}: {item.Value}");
            }
        }
    }
}
