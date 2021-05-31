using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.ar/search?q=" + tBuscar.Text + "&source=hp&ei=02N0YJOONMqx5OUPgbGGgAs&iflsig=AINFCbYAAAAAYHRx498oX_pJq3Ez2Vd0c4m0u7XT2iRh&oq= " + tBuscar.Text + "perro&gs_lcp=Cgdnd3Mtd2l6EAMyCAguELEDEJMCMgUILhCxAzIFCAAQsQMyBQgAELEDMgUILhCxAzIFCAAQsQMyBQguELEDMgUILhCxAzIFCC4QsQMyBQgAELEDOggIABCxAxCDAToLCAAQsQMQxwEQowI6CAguELEDEIMBOgIIADoLCAAQsQMQxwEQrwE6DggAELEDEIMBEMcBEKMCULsMWI8TYNkUaABwAHgAgAFMiAHQApIBATWYAQCgAQGqAQdnd3Mtd2l6&sclient=gws-wiz&ved=0ahUKEwjTw_3B__jvAhXKGLkGHYGYAbAQ4dUDCAc&uact=5");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void bRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void bVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            bBuscar.Visible = !bBuscar.Visible;
        }

        private void bIr_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBuscar.Text))
                return;
            if (tBuscar.Equals("about:blank"))
                return;
            if (!tBuscar.Text.StartsWith("http://") && !tBuscar.Text.StartsWith("https://"))
            {
                tBuscar.Text = "http://" + tBuscar.Text;
            }
            try
            {
                webBrowser1.Navigate(new Uri(tBuscar.Text));
            }
            catch
            {
                MessageBox.Show("Se produjo un error.");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
