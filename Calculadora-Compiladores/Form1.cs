using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        int textotam=0,operacion;
        double a = 0, b = 0, c = 0;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }


        private void button15_Click(object sender, EventArgs e)
        {
            String expresion = textBox1.Text;
            b =int.Parse(textBox1.Text.Substring(textotam));
            switch (operacion)
            {
                case 0:
                    c = a+b;
                    textBox1.Text = "Resultado=" + c;
                    break;
                case 1:
                    c = a - b;
                    textBox1.Text = "Resultado=" + c;
                    break;
                case 2:
                    c = a * b;
                    textBox1.Text = "Resultado=" + c;
                    break;
                case 3:
                    if (b != 0) { c = a/b; textBox1.Text = "Resultado=" + c; }
                    else { textBox1.Text = "ERROR"; }
                    break;
                default:
                    break;
            }
            
            button11.Enabled =false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength>0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            button11.Enabled = true;
            btnsuma.Enabled = true;
            btnresta.Enabled = true;
            btnmultiplicacion.Enabled = true;
            btndivision.Enabled = true;
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.ToString().Equals(""))
            {
                a = int.Parse(textBox1.Text.ToString());
                textBox1.Text = textBox1.Text.ToString() + ((Button)sender).Text + "\r\n";
                textotam = textBox1.Text.Length;
                operacion = 3;
                btnsuma.Enabled = false;
                btnresta.Enabled = false;
                btnmultiplicacion.Enabled = false;
                btndivision.Enabled = false;
                btnsuma.Enabled = false;
                btnresta.Enabled = false;
                btnmultiplicacion.Enabled = false;
                btndivision.Enabled = false;
            }
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.ToString().Equals(""))
            {
                a = int.Parse(textBox1.Text.ToString());
                textBox1.Text = textBox1.Text.ToString() + ((Button)sender).Text + "\r\n";
                textotam = textBox1.Text.Length;
                operacion = 0;
                btnsuma.Enabled = false;
                btnresta.Enabled = false;
                btnmultiplicacion.Enabled = false;
                btndivision.Enabled = false;
            }
            
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.ToString().Equals(""))
            {
                a = int.Parse(textBox1.Text.ToString());
                textBox1.Text = textBox1.Text.ToString() + ((Button)sender).Text + "\r\n";
                textotam = textBox1.Text.Length;
                operacion = 1;
                btnsuma.Enabled = false;
                btnresta.Enabled = false;
                btnmultiplicacion.Enabled = false;
                btndivision.Enabled = false;
            }
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.ToString().Equals(""))
            {
                a = int.Parse(textBox1.Text.ToString());
                textBox1.Text = textBox1.Text.ToString() + ((Button)sender).Text + "\r\n";
                textotam = textBox1.Text.Length;
                operacion = 2;
                btnsuma.Enabled = false;
                btnresta.Enabled = false;
                btnmultiplicacion.Enabled = false;
                btndivision.Enabled = false;
            }
        }
    }
}
