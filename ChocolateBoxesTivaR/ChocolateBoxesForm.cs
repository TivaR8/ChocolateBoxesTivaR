using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 04-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Chocolate Boxes
 * This program has you enter the number of chocolate boxes sold...
 * ... and then tells you what kind of prize you won based on that.
*/

namespace ChocolateBoxesTivaR
{
    public partial class frmChocolateBoxes : Form
    {
        // Variables and constants
        const int BIGPRIZE = 20;
        const int MENTION = 10;
        public frmChocolateBoxes()
        {
            InitializeComponent();

            // To hide the text that displays the size of the prize
            lblSizeOfPrize.Hide();
        }

        private void lblGetPrize_Click(object sender, EventArgs e)
        {
            // Variables
            int soldBoxes;

            // To get the number from the text box
            soldBoxes = int.Parse(txtBoxesSold.Text);

            if (soldBoxes > BIGPRIZE)
            {
                // To show the size of the prize and tell the user
                lblSizeOfPrize.Show();
                lblSizeOfPrize.Text = ("You got a Prize!");
            }
            else
            {
                if (soldBoxes < MENTION + 1)
                {
                    // To show the size of the prize and tell the user
                    lblSizeOfPrize.Show();
                    lblSizeOfPrize.Text = ("You got an honorable mention");
                }
                else
                {
                    // To show the size of the prize and tell the user
                    lblSizeOfPrize.Show();
                    lblSizeOfPrize.Text = ("You got a small prize.");
                }
            }

        }
    }
}
