using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones_basicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaracion de dos variables de tipo entero (integer)
            int numero1 = Int32.Parse(textBox1.Text);
            int numero2 = Int32.Parse(textBox2.Text);

            //Operacion suma 
            if (radioButton1.Checked)
            {double suma = numero1 + numero2;
                MessageBox.Show("Resultado suma= " + suma);
            }
            //Operacion para la seleccion de resta
            if (radioButton2.Checked)
            {double resta = numero1 - numero2;
                MessageBox.Show("Resultado resta=" + resta);
            }
            //Operacion para la seleccion de multiplicacion
            if (radioButton3.Checked==true)
            {double multiplicacion = numero1 * numero2;
                MessageBox.Show("Resultado multiplicacion=" + multiplicacion);
            }
            //Operacion para la seleccion de la division
            if (radioButton4.Checked)
            { double division = numero1 / numero2;
                MessageBox.Show("Resultado division=" + division);
            }
        }
    }
}
