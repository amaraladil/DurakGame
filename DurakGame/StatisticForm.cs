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
 * This shows the statisitcs that occur inside the game itself
 * 
 * Author: Group 2 (Amar Al-Adil, Julian Finley, John Mksyartinian, Madison Tooley)
 * Date: 2017-04-13
 * 
 */

namespace DurakGame
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Starts the form page
        /// </summary>
        /// <param name="sender">Form</param>
        /// <param name="e">Load Event</param>
        private void Form2_Load(object sender, EventArgs e)
        {
            setLabelText();
        }


        /// <summary>
        /// Closes the form report itself
        /// </summary>
        /// <param name="sender">Close Button</param>
        /// <param name="e">Click Event</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// If the user wants to reset their statistics from the program
        /// </summary>
        /// <param name="sender">Reset Button </param>
        /// <param name="e">Click Event</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("This Will Completely Remove Your Saved History. \nAre you Sure?", "Reset Stats", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.wins = 0;
                Properties.Settings.Default.lose = 0;
                Properties.Settings.Default.twentyFourCount = 0;
                Properties.Settings.Default.thirtySixCount = 0;
                Properties.Settings.Default.fiftyTwoCount = 0;
                Properties.Settings.Default.Save();

                setLabelText();
            }
        }



        /// <summary>
        /// This method inserts the values into each label respectively 
        /// </summary>
        private void setLabelText()
        {
            lblWinsCount.Text = Properties.Settings.Default.wins.ToString();
            lblTieCount.Text = Properties.Settings.Default.draw.ToString();
            lblLossCount.Text = Properties.Settings.Default.lose.ToString();
            lblCountTwentyFour.Text = Properties.Settings.Default.twentyFourCount.ToString();
            lblCountThirtySix.Text = Properties.Settings.Default.thirtySixCount.ToString();
            lblCountFiftyTwo.Text = Properties.Settings.Default.fiftyTwoCount.ToString();

        }
    }
}
