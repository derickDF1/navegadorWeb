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
        List<Url> ListaUrls = new List<Url>();
        

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
            string urlIngresado = comboBox1.Text.Trim();
            urlIngresado = urlIngresado.ToLower();

            if (!urlIngresado.StartsWith("http://") && !urlIngresado.StartsWith("https://"))
            {
                if (!urlIngresado.Contains("."))
                {
                    urlIngresado = "https://www.google.com/search?q=" + Uri.EscapeDataString(urlIngresado);
                }
                else
                {
                    urlIngresado = "https://" + urlIngresado + "/";
                }
                comboBox1.Text = urlIngresado;
            }

            Url urlExiste = ListaUrls.FirstOrDefault(u => u.Pagina.ToLower() == urlIngresado);

            if (urlExiste == null)
            {
                Url urlNueva = new Url();
                urlNueva.Pagina = urlIngresado;
                urlNueva.Veces = 1;
                urlNueva.Fecha = DateTime.Now;
                ListaUrls.Add(urlNueva);
            }
            else
            {
                urlExiste.Veces++;
                urlExiste.Fecha = DateTime.Now;
            }

            webView21.CoreWebView2.Navigate(urlIngresado);

            Guardar(@"C:\Users\derickcux2023\source\repos\navegadorWeb\historial.txt", comboBox1.Text);
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
            FileStream flujo = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(flujo);
            ListaUrls.Clear();

            while (lector.Peek() > -1)
            {
                Url url = new Url();
                url.Pagina = lector.ReadLine();
                string veces = Convert.ToString(lector.ReadLine());
                url.Veces = Convert.ToInt32(veces);
                url.Fecha = Convert.ToDateTime(lector.ReadLine());
                //string textoLeido = lector.ReadLine();
                //comboBox1.Items.Add(textoLeido);
                ListaUrls.Add(url);
            }
            lector.Close();

            comboBox1.DisplayMember = "Pagina";
            comboBox1.DataSource = ListaUrls;
            comboBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leer();
        }

        private void Guardar(string fileName, string texto)
        {
            FileStream flujo = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter lector = new StreamWriter(flujo);
            foreach (Url url in ListaUrls)
            {
                lector.WriteLine(url.Pagina);
                lector.WriteLine(url.Veces);
                lector.WriteLine(url.Fecha);
            }
            lector.Close();
        }
    }
}
