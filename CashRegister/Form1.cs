using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //global variables
        double sashimiPiece = 4.50;
        double sushiPiece = 4.50;
        double rolls = 8.99;
        int numOfSashimi = 0;
        int numOfSushi = 0;
        int numOfRolls = 0;
        double subtotal;
        double taxRate = 0.13;
        double tax;
        double total;
        double tendered;
        double changeAmount;
        double titleCount = 0;
        double amountNeeded;
        public Form1()
        {
        InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        tenderedText.Enabled = false;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {

            //Gets Inputs
            numOfSashimi = Convert.ToInt16(sashimiInput.Text);
            numOfSushi = Convert.ToInt16(sushiInput.Text);
            numOfRolls = Convert.ToInt16(rollInput.Text);




            //Calculate Values
            subtotal = (numOfSashimi * sashimiPiece) + (numOfSushi * sushiPiece) + (numOfRolls * rolls);
            tax = subtotal * taxRate;
            total = subtotal + tax;




            //Prints Outputs
            subtotalPrice.Text = $"{subtotal.ToString("$.00")}";
            taxAmount.Text = $"{tax.ToString("C")}";
            totalPrice.Text = $"{total.ToString("C")}";
            tenderedText.Enabled = true;
            }
            //Catch any Errors if letters are inputed
            catch
            {
            subtotalPrice.Text = "ERROR";
            taxAmount.Text = "ERROR";
            totalPrice.Text = "ERROR";
            changeButton.Enabled = false;
            tenderedText.Enabled = false;
            }
            calcButton.Enabled = false;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            SoundPlayer ching = new SoundPlayer(Properties.Resources.Ching);

            //Reads if letters are inputed instead of Numbers
            try
            {
            tendered = Convert.ToDouble(tenderedText.Text);
            //Easter Egg
            if (tendered >= 500)
            {
            sushibarLabel.Text = "SUPER RICH WOW!";
            ching.Play();
            }



            //if statement to see if tendered is more of equal to total
            if (tendered >= total)
            {
            ching.Play();
            changeAmount = tendered - total;
            changeTotal.Text = $"{changeAmount.ToString("C")}";
            recieptPrint.Enabled = true;
            }
            else
            {



            //if tendered less than total Error 
            amountNeeded = total - tendered;
            changeTotal.Text = $"{amountNeeded.ToString("$.00")} Needed";
            recieptPrint.Enabled = false;
            }


            }
            catch
            {

            changeTotal.Text = "ERROR";
            }
            changeButton.Enabled = false;
        }

        private void sashimiInput_TextChanged(object sender, EventArgs e)
        {
        calcButton.Enabled = true;
        }

        private void sushiInput_TextChanged(object sender, EventArgs e)
        {
        calcButton.Enabled = true;
        }

        private void rollInput_TextChanged(object sender, EventArgs e)
        {
        calcButton.Enabled = true;
        }

        private void tenderedText_TextChanged(object sender, EventArgs e)
        {
        changeButton.Enabled = true;
        }

        private void recieptPrint_Click(object sender, EventArgs e)
        {
            recieptPrint.Enabled = false;

            //Sound played while Reciept is printed
            SoundPlayer print = new SoundPlayer(Properties.Resources.Print);
            print.Play();

            //Prints each line one by one
            recieptLabel.Text = $"                     Pearl Sushi Inc         ";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n\n                          Table 5                         ";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n             September 25th, 2024              ";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n-------------------------------";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n\n    Sashimi x{numOfSashimi}          @ {numOfSashimi * sashimiPiece}";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n    Sushi    x{numOfSushi}          @ {numOfSushi * sushiPiece}";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n    Rolls      x{numOfRolls}         @ {numOfRolls * rolls}";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n\n    Subtotal:             {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n    Tax:                     {tax.ToString("C")}";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n    Price Total:         {total.ToString("C")}";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n\n    Tendered:            ${tendered}";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n    Change:              {changeAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(750);
            recieptLabel.Text += $"\n\n               HAVE A NICE DAY          ";

            neworderButton.Enabled = true;


        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            //resets all Variables to Zero
            numOfRolls = 0;
            numOfSashimi = 0;
            numOfSushi = 0;
            recieptLabel.Text = "";
            sushiInput.Text = "";
            sashimiInput.Text = "";
            rollInput.Text = "";
            subtotalPrice.Text = "0";
            taxAmount.Text = "0";
            totalPrice.Text = "0";
            tenderedText.Text = "";
            changeTotal.Text = "0";
            //disables buttons
            calcButton.Enabled = false;
            changeButton.Enabled = false;
            sushibarLabel.Text = "Sushi Bar";
            titleCount = 0;
        }

        private void sushibarLabel_Click(object sender, EventArgs e)
        {
            //Easter Egg #2 
            titleCount++;
            if (titleCount == 1)
            {
            sushibarLabel.Text = "Pearl Sushi";
            }
            else if (titleCount == 2)
            {
            sushibarLabel.Text = "Help me OUT OF HERE!";
            }
            else if (titleCount == 3)
            {
            sushibarLabel.Text = "Super Idol";
            titleCount = 0;
            }

        }
    }
}


