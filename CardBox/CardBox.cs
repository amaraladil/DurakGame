using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardBoxLib;

/*
 * An object that uses the Card values inside itself
 * 
 * Author: Amar Al-Adil
 * Date: 2017-03-12
 * 
 * Cards from: https://github.com/hayeah/playing-cards-assets
 * Reference: tutorial video
 */

namespace CardBox
{
    public partial class CardBox: UserControl
    {
        #region FIELDS AND PROPERTIES

        /// <summary>
        /// Used for the CardBox that has been selected
        /// </summary>
        private PlayingCard myCard;
        public PlayingCard Card
        {
            set 
            { 
                myCard = value;
                UpdateCardImage(); ;
            }
            get { return myCard; }
        }

        public Suit Suit
        {
            set
            {
                Card.Suit = value;
                UpdateCardImage();
            }
            get { return Card.Suit; }
        }

        public Rank Rank
        {
            set
            {
                Card.Rank = value;
                UpdateCardImage();
            }
            get { return Card.Rank; }
        }

        public bool FaceUp
        {
            set
            {
                if (myCard.FaceUp != value)
                {
                    myCard.FaceUp = value;
                    UpdateCardImage();

                    if (CardFlipped != null)
                        CardFlipped(this, new EventArgs());
                }
            }
            get { return Card.FaceUp; }
        }

        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            set
            {
                if (myOrientation != value)
                {
                    myOrientation = value;
                    this.Size = new Size(Size.Height, Size.Width);
                    UpdateCardImage();
                }
            }
            get { return myOrientation; }
        }

        private int myValue;
        public int CardValue
        {
            get { return myValue; }
            set { myValue = value; }
        }

        private void UpdateCardImage()
        {
            pbMyPictureBox.Image = myCard.GetCardImage();

            if (myOrientation == Orientation.Horizontal)
            {
                pbMyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }
        #endregion

        #region CONSTRUCTOR

        /// <summary>
        /// Sets the card object
        /// </summary>
        public CardBox()
        {
            InitializeComponent();
            myOrientation = Orientation.Vertical;
            myCard = new PlayingCard();
            
        }

        /// <summary>
        /// Sets the CardBox with default vertical alignment
        /// </summary>
        /// <param name="card"></param>
        /// <param name="orientation"></param>
        public CardBox(PlayingCard card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();
            myOrientation = orientation;
            myCard = card;
            myValue = (int)card.Rank;
        }


        #endregion

        #region EVENTS AND EVENT HANDLERS
        /// <summary>
        /// Loads the card object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage();
        }

        public event EventHandler CardFlipped;

        new public event EventHandler Click;

        /// <summary>
        /// Sets the card click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMyPictureBox_Click(object sender, EventArgs e)
        {
            if (Click != null)
                Click(this, e);

        }

        #endregion

        #region OTHER METHODS

        public override string ToString()
        {
            return myCard.ToString();
        }
        

        #endregion

        

    }
}
