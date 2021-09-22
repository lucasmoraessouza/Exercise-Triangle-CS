using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lado1;
            double lado2;
            double lado3;


            lado1 = double.Parse(textBox1.Text);
            lado2 = double.Parse(textBox2.Text);
            lado3 = double.Parse(textBox3.Text);

            if((lado1 + lado2) > lado3 || (lado1 + lado3) > lado2 || (lado3 + lado2) > lado1)
            {
                if (lado1 == lado2 && lado1 == lado3)
                {
                    response.Text = "Triângulo Equilátero – Três lados iguais";
                } else if (lado1 == lado2 || lado1 == lado3 || lado3 == lado2 ) {
                    response.Text = "Triângulo Isósceles – Dois lados iguais";
                }
                else
                {
                    response.Text = "Triângulo Escaleno Três lados diferentes.";
                }
            
            }
            else
            {
                response.Text = "Erro! Não é um triângulo.";


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
