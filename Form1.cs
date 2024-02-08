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
            //webView21.GoHome();
        }
         
        private void buttonIr_Click(object sender, EventArgs e)
        {
            String urlIngresado = comboBox1.Text;

            if (!(urlIngresado.StartsWith("https://")))
            {
                if (!(urlIngresado.Contains(".")))
                {
                    urlIngresado = "https://www.google.com/search?q=" + Uri.EscapeDataString(urlIngresado);
                }
                else
                {
                    urlIngresado = "https://" + urlIngresado + "/";
                }
                comboBox1.Text = urlIngresado;
            }
            webView21.CoreWebView2.Navigate(urlIngresado);

        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           webView21.GoForward();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            //webView21.GoHome();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
