using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Create the set of Cards to held together
 * 
 * Author: Amar Al-Adil
 * Date: 2017-03-12
 * 
 * Reference: tutorial video 
 */

namespace CardBoxLib
{
    public class Cards : List<Card>, ICloneable
    {
        
        /// <summary>
        /// Copys the set of cards into another set of cards
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }


    }
}
