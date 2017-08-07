using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form1 : Form
    {
        //int x = 1000;
        double balance = 1000;   // newBalance = newBalance - withdraw 
        int lowBal = 0;             // newBalance -= withdraw
        int withDrawal = 500;          //Try.Parse
        float num, ans;
        int count;
        double temporary;
        string temp1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //balance += 1000;

            textBox1.Text = balance.ToString("C");
            textBox1.ForeColor = Color.Magenta;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = string.Empty;
                textBox1.Text = textBox1.Text = "";
                


            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            temp1 = textBox1.Text;
            double.TryParse(temp1, out temporary);
            if(!double.TryParse(temp1, out temporary))
            {
                textBox1.Text = "Invalid selection";

            }
            else if (balance < temporary)
            {
                textBox1.Text = "Insufficient funds";
            }
            else if ( balance >= temporary)
            {

                balance -= temporary;
            textBox1.Text = balance.ToString("C");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp1 = textBox1.Text;
            double.TryParse(temp1, out temporary);
            if (!double.TryParse(temp1, out temporary))
            {
                textBox1.Text = "Invalid selection";

            }
            else if ()

            { balance += temporary;
                textBox1.Text = balance.ToString("C");
                textBox1.ForeColor = Color.Magenta;
            }


        }
        //private void 

        
    }
}
    
    

            

