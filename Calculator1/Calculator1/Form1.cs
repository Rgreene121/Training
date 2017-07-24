using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        float num, ans;
        int count;
        bool focus;

        public void Disable()
        {
            textBox1.Enabled = false;
            button2.Hide();  //off button
            button1.Show();  //ON Button
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            

        }
        public void enabled()
        {
            textBox1.Enabled = true;
            button1.Hide();  //ON Button
            button2.Show(); //off button
            button3.Enabled = true;
            button4.Enabled = true;
            button7.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
           


        }

        private void button2_Click(object sender, EventArgs e) //OFF Button
        {
            Disable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enabled();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Display 0 in Textbox when press 0 button with red colour
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Magenta;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Display 1 in Textbox when press 1 button with red colour
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Magenta;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Display 2 in Textbox when press 2 button with red colour
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Magenta;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Display 3 in Textbox when press 3 button with red colour
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Magenta;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Display 4 in Textbox when press 4 button with red colour
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Magenta;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Display 5 in Textbox when press 5 button with red colour
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Magenta;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Display 6 in Textbox when press 6 button with red colour
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Magenta;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Display 7 in Textbox when press 7 button with red colour
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Magenta;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Display 8 in Textbox when press 8 button with red colour
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Magenta;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Display 9 in Textbox when press 9 button with red colour
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Magenta;
        }

        private void button5_Click(object sender, EventArgs e) //Addition Button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void button9_Click(object sender, EventArgs e) //Subtract
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button13_Click(object sender, EventArgs e) //Multiply
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button17_Click(object sender, EventArgs e) //Divide
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button20_Click(object sender, EventArgs e) //Equal
        {
            Compute();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = null;
            //label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e) //Decimal Point
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Magenta;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = ""; 
                //textBox1.Clear();

           
        }

        public void Compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;

            }
        }
    }
}
