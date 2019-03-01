using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraP1
{
    public partial class btn : Form
    {
        double numero1;
        double numero2;
        string operador;
        public btn()
           
        {
            InitializeComponent();
        }
        Clases.Suma obj = new Clases.Suma();
        Clases.Resta obj1 = new Clases.Resta();
        Clases.Multiplicacion obj2 = new Clases.Multiplicacion();
        Clases.Division obj3 = new Clases.Division();
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btsBorrar_Click(object sender, EventArgs e)
        {

        }


        private void bts1_Click(object sender, EventArgs e)
        {
            btsMostrar.Text = btsMostrar.Text + "1";
        }

        private void bts2_Click(object sender, EventArgs e)
        {
            btsMostrar.Text = btsMostrar.Text + "2";
        }

        private void bts3_Click(object sender, EventArgs e)
        {
            btsMostrar.Text = btsMostrar.Text + "3";
        }

        
        private void bts4_Click(object sender, EventArgs e)
        {
            btsMostrar.Text = btsMostrar.Text + "4";
        }

        private void bts5_Click(object sender, EventArgs e)
        {
            btsMostrar.Text = btsMostrar.Text + "5";
        }

        private void bts6_Click(object sender, EventArgs e)
        {
            btsMostrar.Text = btsMostrar.Text + "6";
        }

        private void bts7_Click(object sender, EventArgs e)
        {
            btsMostrar.Text = btsMostrar.Text + "7";
        }

        private void bts8_Click(object sender, EventArgs e)
        {
            btsMostrar.Text = btsMostrar.Text + "8";
        }

        private void bts9_Click(object sender, EventArgs e)
        {
            btsMostrar.Text = btsMostrar.Text + "9";
        }
        private void bts0_Click(object sender, EventArgs e)
        {
            btsMostrar.Text = btsMostrar.Text + "0";
        }
        private void btsSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            numero1 = double.Parse(btsMostrar.Text);
            btsMostrar.Clear();
        }

        private void btsMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "x";
            numero1 = double.Parse(btsMostrar.Text);
            btsMostrar.Clear();
        }

        private void btsResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            numero1 = double.Parse(btsMostrar.Text);
            btsMostrar.Clear();
        }

        private void btsDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            numero1 = double.Parse(btsMostrar.Text);
            btsMostrar.Clear();
        }

        private void btsMostrar_TextChanged(object sender, EventArgs e)
        {
            var text = btsMostrar.Text;
            numero2 = Convert.ToDouble(btsMostrar.Text);
            double Sum;
            switch (operador)
            {
                case "+":
                    Sum = obj.Sumas(numero1, (numero2));
                    btsMostrar.Text = Sum.ToString();
                break;
             }
        }
    }
}
