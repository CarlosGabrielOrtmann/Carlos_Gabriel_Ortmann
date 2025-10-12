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
    public partial class FrmColaProcesos : Form
    {
        private Queue<string> procesos = new();

        public FrmColaProcesos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string proceso = txtProceso.Text.Trim();
            if (string.IsNullOrEmpty(proceso))
            {
                MessageBox.Show("Ingrese el nombre del proceso.");
                return;
            }

            procesos.Enqueue(proceso);
            txtProceso.Clear();
            ActualizarLista();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (procesos.Count > 0)
            {
                string ejecutado = procesos.Dequeue();
                MessageBox.Show($"Proceso ejecutado: {ejecutado}");
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("No hay procesos en la cola.");
            }
        }

        private void ActualizarLista()
        {
            lstProcesos.Items.Clear();
            foreach (var p in procesos)
            {
                lstProcesos.Items.Add(p);
            }
        }

        
    }
}
