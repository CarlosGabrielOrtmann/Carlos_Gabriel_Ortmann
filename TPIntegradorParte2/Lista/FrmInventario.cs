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
    public partial class FrmInventario : Form
    {
        private List<Producto> inventario = new();

        public FrmInventario()
        {
            InitializeComponent();
        }

        private void ActualizarGrid()
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = inventario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Complete correctamente los campos.");
                return;
            }

            inventario.Add(new Producto { Nombre = txtNombre.Text, Cantidad = cantidad });
            ActualizarGrid();
            txtNombre.Clear();
            txtCantidad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            var producto = inventario.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (producto != null)
            {
                inventario.Remove(producto);
                ActualizarGrid();
            }
            else
                MessageBox.Show("Producto no encontrado.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            var producto = inventario.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (producto != null)
                MessageBox.Show($"Cantidad disponible: {producto.Cantidad}");
            else
                MessageBox.Show("Producto no encontrado.");
        }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
}
