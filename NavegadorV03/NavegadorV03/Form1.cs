using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorV03
{
    //**NOTAS:

    //WebBrowser.ScriptErrorsSuppressed = true
    //El WebBrowser no mostrará mensajes de dialogo como muestra de errores

    //PrintPreviewDialog && PrintDocument
    //Para la vista previa del cuadro de impresión, añade estos dos controles al formulario
    //Nos vamos a las propiedades del PrintPreviewDialog y en Document le asignamos el PrintDocument que hemos añadido
    //Luego hacemos doble click en el botón que usemos para la lógica del evento ( y ya vemos el código que lleva 
    //línea 149 del código )

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Adapta el formulario al tamaño y posición del escritorio
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        //Evento que sucede cuando se carga el formulario ( la app )
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com");
            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Establece en el texto del Tab el título de la página cargada en el webbrowser
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
        }


        private void tboxDireccionUrl_Click(object sender, EventArgs e)
        {
            //Dejamos NULO de momento
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.Navigate(tboxDireccionUrl.Text);
            }
        }


        //Lógica del evento habilitado para btnGo ( flechita justo detrás del campo para la url )
        WebBrowser webTab = null;
        private void btnNewTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Pestaña nueva";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.com");
            tboxDireccionUrl.Text = "https://www.google.com";
            webTab.DocumentCompleted += WebTab_DocumentComplete;
        }

        private void WebTab_DocumentComplete(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webTab.DocumentTitle;
        }

        //Lógica del evento habilitado para btnBack ( flechita atrás )
        private void btnBack_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;

            if (web != null)
            {
                if (web.CanGoBack)
                {
                    web.GoBack();
                }
            }
        }

        //Lógica del evento habilitado para btnNext ( flechita adelante )
        private void btnNext_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;

            if (web != null)
            {
                if (web.CanGoForward)
                {
                    web.GoForward();
                }
            }
        }
  
        private void tboxDireccionUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DEJAMOS NULL de momento
        }

        //Lógica del evento cuando presionamos enter en el texto del Direcciones URL
        private void tboxDireccionUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;

                if (web != null)
                {
                    web.Navigate(tboxDireccionUrl.Text);
                }
            }
        }


        //Lógica del evento habilitado para btnGuardar ( item de ARCHIVO )
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Aquí iría el código para abrir y leer nuestro archivo

                //Simplemente lo mostramos en una ventana emergente de diálogo
                MessageBox.Show(openFileDialog.FileName);
            }
        }

        //Lógica del evento habilitado para btnVistaPrevia ( item de ARCHIVO )
        private void vistaPreviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }


        //Lógica del evento habilitado para printDocument
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("PÁGINA DE PRUEBA PARA IMPRESIÓN",
                                  new Font("Time Roman", 18, FontStyle.Regular),
                                  Brushes.Black, new Point(25, 100));
        }

        //Lógica del evento habilitado en el btnImprimir ( item de ARCHIVO )
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printD = new PrintDialog();

            printD.ShowDialog();
        }

        //Lógica del evento habilitado en btnSalir ( item de Archivo )
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
