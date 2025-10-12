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
    public partial class FrmParentesis : Form
    {
        public FrmParentesis()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string expresion = txtExpresion.Text.Trim();
            if (string.IsNullOrEmpty(expresion))
            {
                MessageBox.Show("Ingrese una expresión válida.");
                return;
            }

            Stack<char> pila = new();
            bool correcto = true;

            foreach (char c in expresion)
            {
                if (c == '(' || c == '{' || c == '[')
                    pila.Push(c);
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Count == 0)
                    {
                        correcto = false;
                        break;
                    }

                    char abrir = pila.Pop();
                    if ((c == ')' && abrir != '(') ||
                        (c == '}' && abrir != '{') ||
                        (c == ']' && abrir != '['))
                    {
                        correcto = false;
                        break;
                    }
                }
            }

            if (pila.Count > 0) correcto = false;

            lblResultado.Text = correcto ? "Balanceado" : "No balanceado";
        }
    }
}