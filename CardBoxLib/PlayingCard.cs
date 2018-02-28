using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

/*
 * This Playing Card is used primarily for the CardBox object
 * 
 * Author: Group 2 (Amar Al-Adil, Julian Finley, John Mksyartinian, Madison Tooley)
 * Date: 2017-03-12
 * 
 * Cards from: https://github.com/hayeah/playing-cards-assets
 */

namespace CardBoxLib
{
    public class PlayingCard : ICloneable, 
        
                                IComparable
    {
        #region FIELDS AND PROPERTIES

        /// <summary>
        /// Card's Suit
        /// </summary>
        protected Suit mySuit;
        public Suit Suit
        {
            get { return mySuit; }
            set { mySuit = value; }
        }

        /// <summary>
        /// Card's Rank
        /// </summary>
        protected Rank myRank;
        public Rank Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }
        
        /// <summary>
        /// Card's Value
        /// </summary>
        protected int myValue;
        public int CardValue
        {
            get { return myValue; }
            set { myValue = value; }
        }

        /// <summary>
        /// Card's Alternate Value given
        /// </summary>
        protected int? altValue = null;
        public int? AlternateValue
        {
            get { return altValue; }
            set { altValue = value; }
        }

        /// <summary>
        /// Card's face up or not
        /// </summary>
        protected bool faceUp = false;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

        #endregion

        #region CONSTRUCTOR

        /// <summary>
        /// Sets the card object for the CardBox
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="suit"></param>
        public PlayingCard(Rank rank = Rank.Ace, Suit suit = Suit.Hearts)
        {
            this.myRank = rank;
            this.mySuit = suit;
            this.myValue = (int)rank;
        }

        #endregion

        #region PUBLIC METHODS

        public virtual int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Unable to compare a Card to a null object.");
            }

            PlayingCard compareCard = obj as PlayingCard;

            if (compareCard != null)
            {
                int thisSort = this.myValue * 10 + (int)this.mySuit;
                int compareCardSort = compareCard.myValue * 10 + (int)compareCard.mySuit;
                return (thisSort.CompareTo(compareCardSort));
            }
            else
            {
                throw new ArgumentException("Object being compared cannot be converted to a Card.");
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            string cardString;

            if (faceUp)
            {    
                cardString = myRank.ToString() + " of " + mySuit.ToString();
            }
            else
            {
                cardString = "Face Down";
            }

            return cardString;
        }

        public override bool Equals(object obj)
        {
            return (this.CardValue == ((PlayingCard)obj).CardValue);
        }

        public override int GetHashCode()
        {
            return this.myValue * 100 + (int)this.mySuit * 10 + ((this.faceUp)?1:0);
        }

        /// <summary>
        /// Gets the image object for the CardBox
        /// </summary>
        /// <returns></returns>
        public Image GetCardImage()
        {
            string imageName;
            Image cardImage;

            if (!faceUp)
            {
                imageName = "Back";
            }
            
            else
            {
                imageName = mySuit.ToString() + "_" + myRank.ToString();
            }

            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

            return cardImage;
        }

        public string DebugString()
        {
            string cardState = (string)(myRank.ToString() + " of " + mySuit.ToString()).PadLeft(20);
            cardState += (string)((FaceUp) ? "(Face Up)" : "(Face Down)").PadLeft(12);
            cardState += " Value: " + myValue.ToString().PadLeft(2);
            cardState += ((altValue != null) ? "/" + altValue.ToString() : "");
            return cardState;
        }

        #endregion

        #region RELATIONAL OPERATORS

        public static bool operator ==(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue == right.CardValue);
        }

        public static bool operator !=(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue != right.CardValue);
        }

        public static bool operator <(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue < right.CardValue);
        }

        public static bool operator <=(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue <= right.CardValue);
        }

        public static bool operator >(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue > right.CardValue);
        }

        public static bool operator >=(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue >= right.CardValue);
        }


        #endregion
    }
}
