using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlocNotas
{
    //**NOTAS:

    //OpenFileDialog (No abren)
    //No nos sirve para abrir un archivo, únicamente nos sirve para encontrar 
    //la ruta y el archivo que nosotros deseamos abrir

    //SaveFileDialog (No salvan)
    //Nos va a servir para encontrar la ruta y el archivo que queremos salvar
    //no sirve para salvarlo como tal.

    public partial class Form1 : Form
    {
        string nombreFichero = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NO PONEMOS NADA ( me equivoqué al clicar )
        }

        //Evento NUEVO
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Variables auxiliares
            string nombreFichero = "";         

            //Al pulsar NUEVO si hay algo escrito, pregunta si quiere guardar
            if (idCadenaTexto.Text.Length > 0)
            {
                //Preguntamos si queremos guardar contenido
                DialogResult respuesta = MessageBox.Show("¿ Quieres guardar el contenido ?", "", MessageBoxButtons.YesNoCancel);

                if(respuesta == DialogResult.Yes)
                {
                    nombreFichero = saveFileDialog1.FileName;
                    MessageBox.Show(nombreFichero);
                }
                else
                {
                    idCadenaTexto.Clear();
                }                
            }

            //Si venimos de buscar y queremos usar otro control se esconden controles buscar
            esconderBuscar();
        }

        //Evento ABRIR
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFichero = "";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //Mostramos OpenFileDialog
            if(openFileDialog1.ShowDialog() == DialogResult.Yes)
            {
                nombreFichero = saveFileDialog1.FileName;
                MessageBox.Show(nombreFichero);
            }

            esconderBuscar();
        }

        //Evento GUARDAR
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(nombreFichero == "")
            {
                //Comprobamos si guarda primera vez fichero
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    //Guardamos nombre fichero 
                    nombreFichero = saveFileDialog2.FileName;
                    MessageBox.Show(nombreFichero);
                }
                else
                {
                    //Message guardado fic hy
                }
            }

            esconderBuscar();
        }

        //Evento CORTAR
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(idCadenaTexto.SelectedText);
            idCadenaTexto.SelectedText = string.Empty;

            esconderBuscar();
        }

        //Evento COPIAR
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(idCadenaTexto.SelectedText);

            esconderBuscar();
        }

        //Evento PEGAR
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aux = Clipboard.GetText();
            idCadenaTexto.Text = idCadenaTexto.Text.Insert(idCadenaTexto.SelectionStart, aux);

            esconderBuscar();
        }

        //Evento LIMPIAR TODO
        private void limpiarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idCadenaTexto.Clear();

            esconderBuscar();
        }

        

        //Evento BUSCAR
        private void button1_Click(object sender, EventArgs e)
        {
           //AQUÍ NO VA NADA
        }

        //Cambios sobre la fuente 
        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(idCadenaTexto.Text))
            {
                idCadenaTexto.SelectionFont = font.Font;
            }

            esconderBuscar();

        }

        //Manipulamos color
        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult color = colorDialog1.ShowDialog();

            if (color == DialogResult.OK)
            {
                idCadenaTexto.SelectionColor = colorDialog1.Color;
            }

            esconderBuscar();

        }

        private void idBtnBuscar_Click(object sender, EventArgs e)
        {
            //Aquí va la acción de búsqueda

            //Guarda la cadena escrita ( la cadena que busca el usuario )
            string strBuscamos = idTbBuscar.Text;

            int inicio = 0;
            int final = idCadenaTexto.Text.LastIndexOf(strBuscamos); //Ultima palabra que buscamos en el texto

            //Mientras que no llegue a la última palabra, sigue iterando (sigue buscando cadenas iguales)
            while (inicio < final)
            {
                idCadenaTexto.Find(strBuscamos, inicio, idCadenaTexto.TextLength, RichTextBoxFinds.MatchCase);

                idCadenaTexto.SelectionBackColor = Color.Yellow;

                inicio = idCadenaTexto.Text.IndexOf(strBuscamos, inicio) + 1;
            }
        }
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Al entrar en el evento, el botón de búsqueda de string
            //mas el TextBox que lo relaciona se harán visibles
           
            idTbBuscar.Visible = true;
            idBtnBuscar.Visible = true;           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "BLOC DE NOTAS";   
        }

        //Métodos aparte
        public void esconderBuscar()
        {
            if(idTbBuscar.Visible && idBtnBuscar.Visible)
            {
                idTbBuscar.Visible = false;
                idBtnBuscar.Visible = false;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
