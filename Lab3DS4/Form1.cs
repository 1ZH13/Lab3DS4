using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3DS4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPalabra.MaxLength = 30;
            txtPalabra.TextChanged += listBox1_SelectedIndexChanged;
            txtPalabra.KeyPress += txtPalabra_KeyPress;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txtPalabra.Text.Length == 30)
            {
                lblAdvertencia.Text = "Has alcanzado el limite de 30 caracteres.";
            }
            else
            {
                lblAdvertencia.Text = string.Empty; 
            }


        }

        private void calVocales_Click(object sender, EventArgs e)
        {

            ResultadoDeVocal.Items.Clear();
            resultadoNumerico.Items.Clear();

            try
            {
                if (string.IsNullOrEmpty(txtPalabra.Text.Trim()))
                {
                    MessageBox.Show("Por favor, ingrese una palabra.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string palabra = txtPalabra.Text.Trim();

                if (!palabra.All(c => char.IsLetter(c) || "áéíóúÁÉÍÓÚ".Contains(c)))
                {
                    MessageBox.Show("Por favor, ingrese solo letras y letras con tildes.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                palabra = palabra.ToLower();

                char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú' };

                int contadorVocales = 0;

                foreach (char letra in palabra)
                {
                    if (vocales.Contains(letra))
                    {
                        ResultadoDeVocal.Items.Add(letra);
                        contadorVocales++;
                    }
                }

                resultadoNumerico.Items.Add($"La palabra contiene {contadorVocales} vocal(es)...");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lblAdvertencia_Click(object sender, EventArgs e)
        {

        }

        private void resultadoNumerico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPalabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    
