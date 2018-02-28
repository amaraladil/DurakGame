using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * This the main game for Durak, it handles most of the controls with the help of othe library objects
 * 
 * Author: Group 2 (Amar Al-Adil, Julian Finley, John Mksyartinian, Madison Tooley)
 * Date: 2017-04-13
 * 
 */


namespace CardBoxLib
{
    public class Deck
    {
        public event EventHandler LastCardDrawn;

        private Cards cards = new Cards();
        public int NumberOfCards = 52;

        /// <summary>
        /// Default Constructor, with cards set to 52
        /// </summary>
        public Deck()
        {
            // Line of code removed here
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        /// <summary>
        /// Checks if the card number has been changed
        /// </summary>
        /// <param name="cardsInDeck"></param>
        public Deck(int cardsInDeck)
        {
            int startRank = 1;
            if (cardsInDeck == 24) { startRank = 8; }
            if (cardsInDeck == 36) { startRank = 5; }

            NumberOfCards = cardsInDeck;

            // Line of code removed here
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = startRank; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }


        /// <summary>
        /// This method would shuffle the cards inside the deck
        /// </summary>
        public void Shuffle()
        {
            Cards newDeck = new Cards();

            bool[] assigned = new bool[NumberOfCards];

            Random sourceGen = new Random();

            for (int i = 0; i < NumberOfCards; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;

                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(NumberOfCards);

                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }

                assigned[sourceCard] = true;

                newDeck.Add(cards[sourceCard]);
            }

            cards = newDeck;
        }

        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);
            return newDeck;
        }

        public object Clone(Cards newDeckSet)
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);
            return newDeck;
        }

        /// <summary>
        /// Sets the cards to equal the cards given for the Deck
        /// </summary>
        /// <param name="newCards"></param>
        private Deck(Cards newCards)
        {
            cards = newCards;
        }
        
        /// <summary>
        /// Lets the player to get the card depending on the position of the card
        /// </summary>
        /// <param name="cardNum"></param>
        /// <returns></returns>
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= this.cards.Count - 1)
            {
                if ((cardNum == NumberOfCards-1) && (LastCardDrawn != null))
                    LastCardDrawn(this, EventArgs.Empty);
                return cards[cardNum];
            }
            else
                throw new CardOutOfRangeException(this.cards.Count.ToString());
        }

    }
}
