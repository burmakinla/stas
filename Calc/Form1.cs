using System;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void InputNumber(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        double a = 0, b = 0, c = 0;
        char sign = '+';

        private void Computation(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
               
                a = Convert.ToDouble(textBox1.Text);
                sign = (sender as Button).Text[0];
                textBox1.Clear();
            }
        }

        private void Result(object sender, EventArgs e)
        {
            
            b = Convert.ToDouble(textBox1.Text);
           
                switch (sign)
                {
                  
                    case '+': c = a + b;
                        break;
                    case '-': c = a - b;
                        break;
                    case 'X': c = a * b;
                        break;
                    case '/': c = a / b;
                        break;
                    case '^': c = Math.Pow(a, b);
                        break;
          
                }
                textBox1.Text = c.ToString();
         }
    

           
        

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Sqrt(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                c = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                textBox1.Text = c.ToString();
            }
            else
            {
                return;
            }
        }

        private void MinusDegree(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                c = 1 / Convert.ToDouble(textBox1.Text);
                textBox1.Text = c.ToString();
            }
            else
            {
                return;
            }

        }

        private void DoubleMinus(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = '-' + textBox1.Text;
        }

        private void Comma(object sender, EventArgs e)
        {
           
            if (textBox1.Text.IndexOf(',') == -1)
                {
                textBox1.Text += ",";
                }
        }

        private void InputKey(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',') || (e.KeyChar == '-')) & (e.KeyChar != '.'))
            {
                string s = textBox1.Text;
                if (e.KeyChar == ',')
                {
                    int i = s.IndexOf(",", 0, s.Length);
                    if (i != (-1))
                    {
                        e.KeyChar = (char)Keys.None;
                    }
                }
                if (e.KeyChar == '-')
                {
 
                    int i = s.Length;
                    if (i > 0)
                    {
                        e.KeyChar = (char)Keys.None;
                    }
 
                }
 
            }
            else
                e.KeyChar = (char)Keys.None;
 
 
        
            if (e.KeyChar == ',')
                {
                    if (textBox1.Text.IndexOf(',') != -1)
                        {
                          e.Handled = true;
                        }
                }
        }
    }
}
        

