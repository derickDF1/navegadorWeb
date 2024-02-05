using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void buttonIr_Click(object sender, EventArgs e)
        {
            String urlIngresado = comboBox1.Text;

            if (urlIngresado.Contains("https://"))
            {
                String urlCompleto = "https://" + urlIngresado + "/";
                comboBox1.Text = urlCompleto;
            }

            if (urlIngresado.Contains(".") == true)
            {
                String urlCompleto = "https://www.google.com/search?q=" + urlIngresado;
            }

            webBrowser1.Navigate(new Uri(comboBox1.SelectedItem.ToString()));
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            //webBrowser1.GoHome();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
