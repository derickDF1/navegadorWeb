using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace navegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
            buttonIr.Left = this.ClientSize.Width - buttonIr.Width;
            comboBox1.Width = buttonIr.Left - comboBox1.Left;
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.google.com/");
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
