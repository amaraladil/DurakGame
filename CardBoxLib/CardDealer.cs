using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBoxLib
{
    public class CardDealer
    {
        private Deck myDeck;
        private int myNumberOfDecks;
        //private int redCardPosition;

        public CardDealer()
        {
            throw new System.NotImplementedException();
        }

        public CardDealer(Deck cards, int number)
        {
            myDeck = cards;
            NumberOfDecks = number;
        }

        //public CardDealer()
        //{
        //    throw new System.NotImplementedException();
        //}

        public int CardsRemaining
        {
            get
            {
                //myDeck.
                //return myDeck;
                return 0;
            }
            
        }

        public bool Empty
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int NumberOfDecks
        {
            get
            {
                return myNumberOfDecks;
            }
            set
            {
                myNumberOfDecks = value;
            }
        }

        public int RedCardReached
        {
            get
            {
                return myNumberOfDecks;
            }
            set
            {
                myNumberOfDecks = value;
            }
        }

        public void Clone()
        {
            throw new System.NotImplementedException();
        }

        public void DrawCard(bool drawFaceUp = false)
        {
            throw new System.NotImplementedException();
        }

        public void LoadCardDealer()
        {
            throw new System.NotImplementedException();
        }

        public void Shuffle()
        {
            throw new System.NotImplementedException();
        }
    }
}
