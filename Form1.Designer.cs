
namespace navegadorWeb
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIr = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaToolStripMenuItem,
            this.atrasToolStripMenuItem,
            this.adelanteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.busquedaToolStripMenuItem.Text = "Inicio";
            this.busquedaToolStripMenuItem.Click += new System.EventHandler(this.busquedaToolStripMenuItem_Click);
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // adelanteToolStripMenuItem
            // 
            this.adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            this.adelanteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.adelanteToolStripMenuItem.Text = "Adelante";
            this.adelanteToolStripMenuItem.Click += new System.EventHandler(this.adelanteToolStripMenuItem_Click);
            // 
            // buttonIr
            // 
            this.buttonIr.Location = new System.Drawing.Point(940, 34);
            this.buttonIr.Name = "buttonIr";
            this.buttonIr.Size = new System.Drawing.Size(75, 23);
            this.buttonIr.TabIndex = 2;
            this.buttonIr.Text = "Ir";
            this.buttonIr.UseVisualStyleBackColor = true;
            this.buttonIr.Click += new System.EventHandler(this.buttonIr_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "https://www.google.com/",
            "https://virtual.mesoamericana.edu.gt/",
            "https://secretaria.mesoamericana.edu.gt/alumnos/Account/Login.aspx?ReturnUrl=%2fa" +
                "lumnos%2f",
            "https://www.youtube.com/",
            "https://www.facebook.com/"});
            this.comboBox1.Location = new System.Drawing.Point(12, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(904, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 68);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1003, 552);
            this.webView21.Source = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 632);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonIr);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Fast";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonIr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adelanteToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

