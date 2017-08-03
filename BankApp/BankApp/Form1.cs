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
        double newBalance;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Console.WriteLine($"Your current available balance is {balance}");
            textBox1.Text = balance.ToString("C");
            //textBox1.Text +
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = string.Empty;
                textBox1.Text = textBox1.Text + "1";


            }
        }

        private void button2_Click(double balance, out double newBalance)
        {
            newBalance = balance - float.Parse(textBox1.Text);
            textBox1.Text = balance.ToString();

            ////decimal amount;
            //if (double.TryParse(double balance, out newBalance))
            //{
            //    account.Deposit(amount);
            //    account.Balance += newBalance;
            //    depositTextBox.Clear();
            //    balanceLabel.Text = account.Balance.ToString("c"); // This line added

            //take text from txtbox1, tryparse, save as a number,
            // substract that number from balance

        }
        


        //public void Compute()
        //{
        //    switch (count)
        //    {
        //        case 1:
        //            newBalance = newBalance + double.Parse(textBox1.Text);
        //            textBox1.Text = newBalance.ToString();
        //            break;

        //        case 2:
        //            newBalance = newBalance - double.Parse(textBox1.Text);
        //            textBox1.Text = newBalance.ToString();
        //            break;
    }
}//    }
    
    

            

