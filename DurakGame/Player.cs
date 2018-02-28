using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardBoxLib;

/*
 * This the main game for Durak, it handles most of the controls with the help of othe library objects
 * 
 * Author: Group 2 (Amar Al-Adil, Julian Finley, John Mksyartinian, Madison Tooley)
 * Date: 2017-04-13
 * 
 */


namespace DurakGame
{
    class Player
    {
        /// <summary>
        /// Sets the name given for the player
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The cards are stored inside here for each player
        /// </summary>
        public Cards PlayHand { get; private set; }
        //Checks if player is attack or not
        public bool isAttack { get; internal set; }
        private Player()
        {
            PlayHand = new Cards();
        }

        /// <summary>
        /// Constructor with the name being set, 
        /// was not used because there is 
        /// only two players playing
        /// </summary>
        /// <param name="name"></param>
        public Player(string name)
        {
            Name = name;
            PlayHand = new Cards();
        }
        


    }
}
