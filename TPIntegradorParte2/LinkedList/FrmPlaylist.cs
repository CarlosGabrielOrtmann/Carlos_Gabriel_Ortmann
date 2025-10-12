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
    public partial class FrmPlaylist : Form
    {
        private LinkedList<string> playlist = new();
        private LinkedListNode<string> cancionActual = null;

        public FrmPlaylist()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cancion = txtCancion.Text.Trim();
            if (string.IsNullOrEmpty(cancion))
            {
                MessageBox.Show("Ingrese un nombre de canción válido.");
                return;
            }

            playlist.AddLast(cancion);
            if (cancionActual == null) cancionActual = playlist.First;
            txtCancion.Clear();
            ActualizarLista();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (cancionActual?.Next != null)
            {
                cancionActual = cancionActual.Next;
                MessageBox.Show($"Canción actual: {cancionActual.Value}");
            }
            else
            {
                MessageBox.Show("No hay canción siguiente.");
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (cancionActual?.Previous != null)
            {
                cancionActual = cancionActual.Previous;
                MessageBox.Show($"Canción actual: {cancionActual.Value}");
            }
            else
            {
                MessageBox.Show("No hay canción anterior.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cancion = txtCancion.Text.Trim();
            if (string.IsNullOrEmpty(cancion))
            {
                MessageBox.Show("Ingrese el nombre de la canción a eliminar.");
                return;
            }

            var nodo = playlist.Find(cancion);
            if (nodo != null)
            {
                if (nodo == cancionActual)
                    cancionActual = nodo.Next ?? nodo.Previous;

                playlist.Remove(nodo);
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("La canción no se encuentra en la lista.");
            }
        }

        private void ActualizarLista()
        {
            lstCanciones.Items.Clear();
            foreach (var c in playlist)
            {
                lstCanciones.Items.Add(c);
            }
        }
    }
}
