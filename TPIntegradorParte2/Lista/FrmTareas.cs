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
    public partial class FrmTareas : Form
    {
        private List<string> tareas = new();

        public FrmTareas()
        {
            InitializeComponent();
        }

        private void ActualizarLista()
        {
            lstTareas.DataSource = null;
            lstTareas.DataSource = new List<string>(tareas);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                tareas.Add(txtTarea.Text);
                txtTarea.Clear();
                ActualizarLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex >= 0)
            {
                tareas.RemoveAt(lstTareas.SelectedIndex);
                ActualizarLista();
            }
        }
    }
}
