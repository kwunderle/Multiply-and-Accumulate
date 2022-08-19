using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAndAccum___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 03/14/2021
    //Goal: Multiply 2 numbers and accumulate totals
    public partial class Form1 : Form
    {
        //Declare variables
        //Input variables
        decimal num1 = 0;
        decimal num2 = 0;
        bool tryParseResult;
        //Output variable
        decimal result = 0;
        //Running total variable
        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //INPUT
            //Receive and verify numeric input from user
            tryParseResult = decimal.TryParse(num1Inpt.Text, out num1);
            if (tryParseResult == false)
            { MessageBox.Show("Error: Please enter a numeric value for Number 1");
                return;
            }
            tryParseResult = decimal.TryParse(num2Inpt.Text, out num2);
            if (tryParseResult == false)
            { MessageBox.Show("Error: Please enter a numeric value for Number 2");
                return;
            }

            //PROCESSING
            //Calculate result
            result = num1 * num2;
            //Accumulate total
            total += result;
            //Set total background color
            if (total <= 0)
            { ttlOtpt.BackColor = Color.Orange; }
            else
            { ttlOtpt.BackColor = Color.LightBlue; }

            //OUTPUT
            //Display result
            rsltOtpt.Text = result.ToString("n2");
            //Display running total
            ttlOtpt.Text = total.ToString("n2");
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clear input text boxes
            num1Inpt.Text = "";
            num2Inpt.Text = "";
            //Clear result output
            rsltOtpt.Text = "";
            //Clear total output
            ttlOtpt.Text = "";
            //Reset running total accumulator
            total = 0;
            //Return background to light blue
            ttlOtpt.BackColor = Color.LightBlue;
        }
    }
}
