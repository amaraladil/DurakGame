using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardBoxLib
{
    public class CardOutOfRangeException : Exception
    {
        private Cards deckContents;
        public Cards DeckContents
        {
            get
            {
                return deckContents;
            }
        }
        public CardOutOfRangeException(Cards sourceDeckContents)
            : base("There are only 36 cards in the deck.")
        {
            deckContents = sourceDeckContents;
        }

        public CardOutOfRangeException(String message)
            : base("There are only " + message.ToString() + " cards in the deck.")
        {
            //deckContents = sourceDeckContents;
        }
    }
}
