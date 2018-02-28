using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Creates the cards values
 * 
 * Author: Amar Al-Adil
 * Date: 2017-03-12
 * 
 * Cards from: https://github.com/hayeah/playing-cards-assets
 * Reference: tutorial video 
 */

namespace CardBoxLib
{
    public class Card : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }

        public readonly Rank rank;
        public readonly Suit suit;
        public readonly int value;

        /// <summary>
        /// The parameterized constructor that takes in the suit and rank
        /// </summary>
        /// <param name="newSuit">Set the card Suit</param>
        /// <param name="newRank">Set the card Rank</param>
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
            value = (int)rank;
        }

        /// <summary>
        /// The Default Constructor
        /// </summary>
        public Card()
        {
            suit = Suit.Clubs;
            rank = Rank.Ace;
            value = (int)rank;
        }

        /// <summary>
        /// Overrides the to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "The " + rank + " of " + suit + "";
        }

        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher
        /// than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;
        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static Suit trump = Suit.Clubs;
        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower
        /// than deuces.
        /// </summary>
        public static bool isAceHigh = true;


        /// <summary>
        /// Sets the hashcode for the cards themselves
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }
        
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }

        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }

        public override bool Equals(object card)
        {
            return this == (Card)card;
        }

        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank > card2.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }

    }
}