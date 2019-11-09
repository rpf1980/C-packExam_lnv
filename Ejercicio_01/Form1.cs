using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{    
    public partial class rootPanel : Form
    {
        //Métodos aparte
        
        public string QuitaAcentos(string cadena)
        {
            string copia = cadena;
            copia = copia.Replace(" ", "");

            string strCon = "áÁé";
            string strSin = "aAe";
            int tama = strCon.Length;
                       
            //Iteramos sobre el tamaño de los string caracteres
            for (int i = 0; i < tama; i++)
            {
                copia = copia.Replace(strCon[i], strSin[i]);
            }
  
            return copia;
        }

        public rootPanel()
        {
            InitializeComponent();
        }

        private void rootPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            btnContar.BackColor = Color.Aqua;
            string strEntrante = idTbCadena.Text;
            strEntrante = QuitaAcentos(strEntrante);

            for (int i = 0; i < strEntrante.Length; i++)
            {
                if(strEntrante[i].ToString() == cmbVocales.SelectedItem.ToString())
                {
                    contador++;
                }
            }

            idTbResultado.Text = contador.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idTbResultado.Text = "";
            idTbCadena.Text = "";          
        }
    }
}
