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
using System.IO;

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
            Guardar(@"C:\Users\derickcux2023\source\repos\navegadorWeb\historial.txt", comboBox1.Text);
            comboBox1.Items.Clear();
            leer();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           webView21.GoForward();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void leer()
        {
            string fileName = @"C:\Users\derickcux2023\source\repos\navegadorWeb\historial.txt";

            FileStream flujo = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(flujo);

            while (lector.Peek() > -1)
            {
                string textoLeido = lector.ReadLine();
                comboBox1.Items.Add(textoLeido);
            }
            lector.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leer();
        }

        private void Guardar(string fileName, string texto)
        {
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(texto);
            writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
