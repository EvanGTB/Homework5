using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudwillLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Evan Budwill
         * 2022/10/06
         * Description: This program lets you multiply two numbers together AND it tells you about my pet cat!!! */

        //This event closes the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This event shows the picture of my cat and hides the label with the information about my cat
        private void btnPicture_Click(object sender, EventArgs e)
        {
            picStar.Show();
            lblData.Hide();
        }

        //This event hides the picture of my cat as well as the label with the information about my cat
        private void btnHide_Click(object sender, EventArgs e)
        {
            picStar.Hide();
            lblData.Hide();
        }

        //This event focuses the user on the first number textbox and it resets both of the textboxes and the answer output
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtMultiplier.Text = "";
            lblOutput.Text = "";
            txtNumber.Focus();
        }

        //This event hides the picture and inputs the information into the label and reveals the label
        private void btnData_Click(object sender, EventArgs e)
        {
            picStar.Hide();
            lblData.Show();
            lblData.Text = "My topic is " + lblStar.Text + "." + Environment.NewLine + Environment.NewLine + "Her name is Star and she is 13 years old. I adopted her when she was a stray kitten." + Environment.NewLine + Environment.NewLine + "Her favourite food is chicken and she probably loves it more than she loves me but that's fine. I buy freeze dried chicken treats for her and she's always asking for some.";
        }

        //This event makes a message box appear when the user clicks on the picture
        private void picStar_Click(object sender, EventArgs e)
        {
            MessageBox("Evan Budwill", "I thought this pose was funny.");
        }

        //This event multiplies the input from the two textboxes together and shows the answer
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number, multiplier, answer;

            number = Convert.ToInt32(txtNumber.Text);
            multiplier = Convert.ToInt32(txtMultiplier.Text);

            answer = number * multiplier;

            lblOutput.Text = answer.ToString();
        }
    }
}
