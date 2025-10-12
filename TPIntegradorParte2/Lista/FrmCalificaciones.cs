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
    public partial class FrmCalificaciones : Form
    {
        private List<double> calificaciones = new();

        public FrmCalificaciones()
        {
            InitializeComponent();
        }

        private void ActualizarLista()
        {
            lstNotas.DataSource = null;
            lstNotas.DataSource = new List<double>(calificaciones);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNota.Text, out double nota))
            {
                calificaciones.Add(nota);
                txtNota.Clear();
                ActualizarLista();
            }
            else
                MessageBox.Show("Ingrese una calificación válida.");
        }

        private void btnEliminarMayor_Click(object sender, EventArgs e)
        {
            if (calificaciones.Count > 0)
            {
                double max = calificaciones.Max();
                calificaciones.Remove(max);
                ActualizarLista();
            }
        }

        private void btnEliminarMenor_Click(object sender, EventArgs e)
        {
            if (calificaciones.Count > 0)
            {
                double min = calificaciones.Min();
                calificaciones.Remove(min);
                ActualizarLista();
            }
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if (calificaciones.Count > 0)
            {
                double promedio = calificaciones.Average();
                lblPromedio.Text = $"Promedio: {promedio:F2}";
            }
            else
                lblPromedio.Text = "Sin calificaciones.";
        }
    }
}
