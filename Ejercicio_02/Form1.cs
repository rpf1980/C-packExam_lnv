using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public partial class Form1 : Form
    {                
        public Form1()
        {
            InitializeComponent();
        }

        private void idBtnAdd_Click(object sender, EventArgs e)
        {         
            if(idListBox.SelectedIndices.Count != -1)
            {
                //Añadimos Items a la lista en cada click sucesivo del evento
                idListBox.Items.Add(idTbName.Text.ToString());
            }

            if (idTbName.Text.ToString().Equals(""))
            {
                //Mostramos si la lista está vacía
                MessageBox.Show("El campo de texto se puede añadir porque está vacío");
            }
            idTbName.Clear();
        }

        private void idBtnDel_Click(object sender, EventArgs e)
        {
            idTbName.Text = "";
            if (idListBox.SelectedIndex != -1)
            {
                for (int i = idListBox.SelectedItems.Count - 1; i >= 0; i--)
                {
                    idListBox.Items.Remove(idListBox.SelectedItems[i]);                    
                }
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados en la lista");
            }
            
        }
    }
}
