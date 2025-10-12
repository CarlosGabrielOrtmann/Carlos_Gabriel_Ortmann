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
    public partial class FrmTraductor : Form
    {
        private Dictionary<string, string> diccionario = new();

        public FrmTraductor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ingles = txtIngles.Text.Trim();
            string espanol = txtEspañol.Text.Trim();

            if (string.IsNullOrEmpty(ingles) || string.IsNullOrEmpty(espanol))
            {
                MessageBox.Show("Ingrese palabra en inglés y su traducción.");
                return;
            }

            diccionario[ingles] = espanol;
            txtIngles.Clear();
            txtEspañol.Clear();
            ActualizarLista();
        }

        private void btnTraducir_Click(object sender, EventArgs e)
        {
            string ingles = txtIngles.Text.Trim();
            if (diccionario.ContainsKey(ingles))
            {
                MessageBox.Show($"Traducción: {diccionario[ingles]}");
            }
            else
            {
                MessageBox.Show("Palabra no encontrada.");
            }
        }

        private void ActualizarLista()
        {
            lstTraducciones.Items.Clear();
            foreach (var item in diccionario)
            {
                lstTraducciones.Items.Add($"{item.Key}: {item.Value}");
            }
        }
    }
}