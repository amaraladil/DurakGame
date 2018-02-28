using CardBoxLib;
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
 * A form that tests the cardbox object with the buttons and click events implemented
 * 
 * Author: Amar Al-Adil
 * Date: 2017-03-12
 * 
 * Cards from: https://github.com/hayeah/playing-cards-assets
 */

namespace CardBoxTester
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void cbxTestCard_Click(object sender, EventArgs e)
        {
            lblClicked.Text = cbxTestCard.ToString() + " was clicked last.";
            if (cbxTestCard.CardOrientation == Orientation.Horizontal)
                cbxTestCard.CardOrientation = Orientation.Vertical;
            else
                cbxTestCard.CardOrientation = Orientation.Horizontal;
            
        }

        private void btnFlipCard_Click(object sender, EventArgs e)
        {
            cbxTestCard.FaceUp = !cbxTestCard.FaceUp;
        }

        private void cboCardName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTestCard.Rank = (CardBoxLib.Rank)cboCardName.SelectedIndex + 1;
        }

        private void cboSuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTestCard.Suit = (CardBoxLib.Suit)cboSuit.SelectedIndex;
        }

        private int flipCount = 0;
        private void cbxTestCard_CardFlipped(object sender, EventArgs e)
        {
            flipCount++;
            lblFlipped.Text = "Card flip: #" + flipCount.ToString();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            PlayingCard theCard = new CardBoxLib.PlayingCard(Rank.Ace, Suit.Clubs);
            theCard.FaceUp = true;
            this.cbxTestCard.Card = theCard;
        }

    }
}
