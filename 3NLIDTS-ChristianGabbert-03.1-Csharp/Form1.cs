using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_ChristianGabbert_03._1_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCelsius.Checked)
                {
                    double c = double.Parse(txtCelsius.Text);
                    txtFahrenheit.Text = (c * 9 / 5 + 32).ToString("0.00");
                    txtKelvin.Text = (c + 273.15).ToString("0.00");
                }
                else if (rbFahrenheit.Checked)
                {
                    double f = double.Parse(txtFahrenheit.Text);
                    txtCelsius.Text = ((f - 32) * 5 / 9).ToString("0.00");
                    txtKelvin.Text = (((f - 32) * 5 / 9) + 273.15).ToString("0.00");
                }
                else if (rbKelvin.Checked)
                {
                    double k = double.Parse(txtKelvin.Text);
                    txtCelsius.Text = (k - 273.15).ToString("0.00");
                    txtFahrenheit.Text = ((k - 273.15) * 9 / 5 + 32).ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Selecciona un tipo de temperatura");
                }
            }
            catch
            {
                MessageBox.Show("Ingresa un valor numerico valido");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();

        }

        private void rbKelvin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKelvin.Checked)
            {
                txtKelvin.Enabled = true;
                txtCelsius.Enabled = false;
                txtFahrenheit.Enabled = false;

                txtCelsius.Text = "";
                txtFahrenheit.Text = "";
            }
        }

        private void rbFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFahrenheit.Checked)
            {
                txtFahrenheit.Enabled = true;
                txtCelsius.Enabled = false;
                txtKelvin.Enabled = false;

                txtCelsius.Text = "";
                txtKelvin.Text = "";
            }
        }

        private void rbCelsius_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCelsius.Checked)
            {
                txtCelsius.Enabled = true;
                txtFahrenheit.Enabled = false;
                txtKelvin.Enabled = false;

                txtFahrenheit.Text = "";
                txtKelvin.Text = "";
            }
        }

        void EstadoInicial()
        {
            rbCelsius.Checked = false;
            rbFahrenheit.Checked = false;
            rbKelvin.Checked = false;

            txtCelsius.Text = "";
            txtFahrenheit.Text = "";
            txtKelvin.Text = "";

            txtCelsius.Enabled = false;
            txtFahrenheit.Enabled = false;
            txtKelvin.Enabled = false;
        }
    }
}
