using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        string tablaMultiAscendente(int n)
        {
            string res = "";

            for (int i = 1; i <= 10; i++)
            {
                res += $"{n} x {i} = {n*i}" + Environment.NewLine;               
            }

            return res;
        }

        string tablaMultiDescendente(int n)
        {
            string res = "";

            for (int i = 10; i >= 1; i--)
            {
                res += $"{n} x {i} = {n * i}" + Environment.NewLine;
            }

            return res;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Guarda el valor entero que muestre el NumericUpDown
            int getValue = Convert.ToInt32(idNumUpDown.Value);

            //El valor guardado del NumericUpDown lo pasamos por parámetro en la función tablaMultiplicar
            string tablaMulti = tablaMultiAscendente(getValue);

            //Mostramos la tabla en orden ascendente
            idTbox.Text = tablaMulti;         
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Guarda valor del NumericUpDown
            int getValue = Convert.ToInt32(idNumUpDown.Value);

            //Usamos el valor guardado en nuestra función multiDescendente
            string tablaMulti = tablaMultiDescendente(getValue);

            //Mostramos la tabal en orden descendente
            idTbox.Text = tablaMulti;
        }
    }
}
