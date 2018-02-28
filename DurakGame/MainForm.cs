using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardBoxLib;
using System.IO;

/*
 * This the main game for Durak, it handles most of the controls with the help of othe library objects
 * 
 * Author: Group 2 (Amar Al-Adil, Julian Finley, John Mksyartinian, Madison Tooley)
 * Date: 2017-04-13
 * 
 */ 


namespace DurakGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Constants And Global Variables

        private const string ATTACKER_NAME = "Attacker"; //Constant for the title for attackers
        private const string DEFENDER_NAME = "Defender"; //Constant for the title for defenders
        private const int PLAYER_STARTING_NUMBER = 5; //Constant for the number of cards each player starts and gets refilled up to
        private const int NUMBER_OF_SHUFFLES = 5; //Constant Number of shuffles
        private const int MAX_NUMBER_OF_PLAYING_CARDS = 7; //Constant for the maximum playing cards on the field
        private const string DISCARD_BUTTON = "Clear Cards"; //Constant for the button text being set for discarding the cards
        private const string TAKE_BUTTON = "Take Cards"; //Constant for the button text being set for taking all the cards

        private Deck playDeck; //The complete deck being used throughout the game
        private CardBox.CardBox cardBoxObject = new CardBox.CardBox(); // The card object that is being used for each card box that is displayed
        private Label trumpLabel = new Label(); // To show text to clarify what is the Trump Suit for the game
        private Player[] players; //An Array of player objects being stored
        private int currentCard = 0; //Global variable to indicate how many cards have been pulled
        private int cardNumber = 0; //Global variable to count for the cardbox name

        private CardBox.CardBox trumpCard = new CardBox.CardBox(); //The trump card is chosen with the first card given
        private Card trumpTaken; //A Card object to make sure which trump card has been used for the game

        private Cards cardsDealt = new Cards(); //Cards object to hold all the cards that have been added to the playing field
        private int dealtX = 150; //Default X position for the cards playing field
        private int dealtY = 200; //Default Y position for the cards playing field


        private int PlayPosX = 100; //Default X position for the Player themselves
        private int PlayPosY = 400; //Default Y position for the Player themselves


        private int PlayAiPosX = 100; //Default X position for the AI Player themselves
        private int PlayAiPosY = 40; //Default Y position for the AI Player themselves

        #endregion



        /// <summary>
        /// When the Whole form loads, it sets the start up objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            btnClearCards.Text = "Start";
            lblMessage.Text = "";
            lblMessageAi.Text = "";
            lblMessagePlayer.Text = "";
            lblWarning.Text = "";

            DurakLog("Durak Game Executeable Opened");
        }
        
        /// <summary>
        /// A method for the defaulting for when refreshing the cards on the form
        /// </summary>
        private void defaultValues()
        {
            dealtX = 100;
            cardNumber = 0;
            PlayPosX = 100;
            PlayAiPosX = 100;
            
        }

        /// <summary>
        /// A method that removes any card object in the game
        /// </summary>
        private void removeAllCardBox()
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CardBox.CardBox)
                {
                    controlsToRemove.Add(ctrl);
                }
            }

            foreach (Control ctrl in controlsToRemove)
            {
                this.Controls.Remove(ctrl);
            }
        }

        /// <summary>
        /// A method that remove the trump image for each game
        /// </summary>
        private void removeTrumpImage()
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox)
                {
                    controlsToRemove.Add(ctrl);
                }
            }

            foreach (Control ctrl in controlsToRemove)
            {
                this.Controls.Remove(ctrl);
            }
        }

        /// <summary>
        /// Sets up the CardBox object inside the form with the right 
        /// values
        /// </summary>
        /// <param name="givenCardBox">The Object itself</param>
        /// <param name="givenCard">The chosen card that will be used for the card itself</param>
        /// <param name="isFaceUp">Makes sure if the card is faced up or not</param>
        /// <param name="isVert">Checks if the card is vertical or horizontal</param>
        /// <param name="givenPosX">Takes in the x position of the CardBox </param>
        /// <param name="givenPosY">Takes in the y position of the CardBox  </param>
        /// <returns></returns>
        private CardBox.CardBox setCardBoxValues(CardBox.CardBox givenCardBox, Card givenCard, bool isFaceUp, bool isVert, int givenPosX, int givenPosY)
        {
            givenCardBox.Location = new Point(givenPosX, givenPosY);
            givenCardBox.Name = "cardboxPlayer" + cardNumber;
            givenCardBox.FaceUp = isFaceUp;
            givenCardBox.CardOrientation = isVert? Orientation.Vertical : Orientation.Horizontal;
            givenCardBox.Rank = givenCard.rank;
            givenCardBox.Suit = givenCard.suit;

            return givenCardBox;

        }

        /// <summary>
        /// This method Starts the game in the form
        /// </summary>
        private void gameSetUp()
        {
            lblMessage.Text = "";
            lblWarning.Text = "";
            currentCard = 0;
            int choice = 2;
            players = new Player[choice];

            //Checks which number of cards have been chosen
            if (rdoMinCard.Checked)
            {
                playDeck = new Deck(24);
                Properties.Settings.Default.twentyFourCount += 1;
            }
            else if ( rdoMediumCard.Checked) //Player chose 36 cards
            {
                playDeck = new Deck(36);
                Properties.Settings.Default.thirtySixCount += 1;
            }
            else //Any other chosen card number, will set default 52 cards
            {
                playDeck = new Deck();
                Properties.Settings.Default.fiftyTwoCount += 1;
            }
            Properties.Settings.Default.Save();

            DurakLog("Player Starts the Game with " + playDeck.NumberOfCards + " cards");

            //Shuffles five times
            for (int x = 0; x < NUMBER_OF_SHUFFLES; x++)
            {
                playDeck.Shuffle();
            }
            
            //Sets the Trump card first
            setTrumpCard();

            //Then both players will get their own cards
            for (int p = 0; p < players.Length; p++)
            {
                players[p] = new Player("A " + p.ToString());

                for (int c = 0; c < PLAYER_STARTING_NUMBER; c++)
                {
                    players[p].PlayHand.Add(playDeck.GetCard(currentCard++));
                }
            }

            //Sets the player to become the defender and the AI being the Attacker
            if (cardsDealt.Count == 0) { players[0].isAttack = false; players[1].isAttack = true; btnClearCards.Text = "Take Cards"; }

            showWhoseAttackDefend();

            setNewCardField();

        }

        /// <summary>
        /// Sets up the trump card Suit for the game
        /// </summary>
        private void setTrumpCard()
        {
            trumpTaken = playDeck.GetCard(currentCard);

            trumpCard.Rank = trumpTaken.rank;
            trumpCard.Suit = trumpTaken.suit;
            trumpCard.FaceUp = true;

            trumpLabel.Location = new Point(10, 150);
            trumpLabel.Text = "Trump is: \n" + trumpCard.Suit.ToString();
            trumpLabel.Font = new Font("Microsoft Sans Serif", 10F);
            trumpLabel.Width = 150;
            trumpLabel.Height = 50;
            trumpLabel.ForeColor = Color.White;
            
            //Sets up the Trump Suit Image for the player to be able to see
            PictureBox trumpImage = new PictureBox();
            trumpImage.Location = new Point(10, 200);
            trumpImage.Width = 70;
            trumpImage.Height = 80;
            trumpImage.SizeMode = PictureBoxSizeMode.StretchImage;
            trumpImage.BackColor = Color.LightGray;
            trumpImage.Image = Properties.Resources.ResourceManager.GetObject(trumpCard.Suit.ToString() + "_") as Image;
            this.Controls.Add(trumpLabel);
            this.Controls.Add(trumpImage);

            DurakLog("Trump Suit was: " + trumpCard.Suit.ToString());
        }

        /// <summary>
        /// Displays who is Attacking and Defending depending
        /// on if they are attacking or not
        /// </summary>
        private void showWhoseAttackDefend()
        {
            if (players[0].isAttack)
            {
                lblMessagePlayer.Text = ATTACKER_NAME;
                lblMessageAi.Text = DEFENDER_NAME;
            }
            else
            {
                lblMessagePlayer.Text = DEFENDER_NAME;
                lblMessageAi.Text = ATTACKER_NAME;
            }
        }

        /// <summary>
        /// This Click method happens for the player's CardBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardboxTest_Click(object sender, EventArgs e)
        {
            int cardClickedValue = 0;
            int lastCardDealtValue = 0;

            lblMessage.Text = "";

            //Sets the player to become the defender and the AI being the Attacker
            if (cardsDealt.Count == 0) { players[0].isAttack = false; players[1].isAttack = true; btnClearCards.Text = TAKE_BUTTON; }

            //Clicked card is set up to check values
            CardBox.CardBox item = (CardBox.CardBox)sender;

            DurakLog("\tPlayer Clicked on " + item.ToString());

            //Checks if playing cards has less than 6 cards
            if (cardsDealt.Count <= MAX_NUMBER_OF_PLAYING_CARDS)
            {


                //Checks if the there is any cards on the playing field
                if (cardsDealt.Count > 0)
                {
                    //Sets the cards values
                    cardClickedValue = (int)item.Rank;
                    lastCardDealtValue = (int)cardsDealt.Last<Card>().rank;

                    //Checks if the clicked object is a trump card
                    if (item.Suit == trumpCard.Suit) { cardClickedValue += 10; }
                    //Checks if the last card on the field, being a trump card
                    if (cardsDealt.Last<Card>().suit == trumpCard.Suit) { lastCardDealtValue += 10; }

                    //Checks if the clicked card value is equal or greater than the last card dealt
                    if (cardClickedValue >= lastCardDealtValue)
                    {
                        DurakLog("\t\t(" + item.ToString() + ") beats last playing card (" + cardsDealt.Last<Card>().ToString() + ")");
                        Card clickedCard = new Card(item.Suit, item.Rank);
                        cardsDealt.Add(clickedCard);

                        players[0].PlayHand.Remove(clickedCard);
                        
                        //Checks if there is enough space for AI to play
                        if (cardsDealt.Count < MAX_NUMBER_OF_PLAYING_CARDS)
                        {
                            //Lets the AI play next
                            if (players[1].PlayHand.Count > 0)
                            {
                                playAiPlayer();
                            }

                            //If AI makes the playing cards full, then it discards the cards.
                            if (cardsDealt.Count == MAX_NUMBER_OF_PLAYING_CARDS)
                            {
                                DurakLog("\tAI Player made the cards full, discarded the cards in playing field");

                                cardsDealt = new Cards();
                                addMoreCardsToPlayerHands();

                                //Makes the player defend and AI attacks
                                if (cardsDealt.Count == 0) { players[0].isAttack = false; players[1].isAttack = true; btnClearCards.Text = TAKE_BUTTON; }

                                showWhoseAttackDefend();
                            }

                        }
                        else //AI has to discard, since the player played the last card to reach the maximum cards in play
                        {
                            
                            cardsDealt = new Cards();
                            
                            AiStartsNewPlayingCards();
                        }
                        

                        setNewCardField();

                    }
                    else//Shows a message that it is not able to be played
                    {
                        lblMessage.Text = item.ToString() + " cannot beat " + cardsDealt.Last<Card>().ToString();
                        DurakLog("\t\t(" + item.ToString() + ") cannot beat last playing card (" + cardsDealt.Last<Card>().ToString() + ")");
                    }


                }
                else //Sets the first card for the playing field from the Player themself
                {
                    Card setCard = new Card(item.Suit, item.Rank);
                    cardsDealt.Add(setCard);

                    players[0].PlayHand.Remove(setCard);
                    DurakLog("\t\t(" + item.ToString() + ") starts the playing cards");

                    //checks if AI player has enough cards
                    if (players[1].PlayHand.Count > 0)
                    {
                        playAiPlayer();

                    }

                    setNewCardField();
                }

                //If AI Player wins or Player Wins
                if (players[1].PlayHand.Count == 0 || players[0].PlayHand.Count == 0)
                {
                    setWinner();
                }
                

            }
            else
            {
                DurakLog("\t\t\tPlaying field is full");
                lblWarning.Text = "Cannot have anymore cards";
            }
        }
        

        /// <summary>
        /// This method is used to set the CardBox objects for 
        /// both players and playing field
        /// </summary>
        private void setNewCardField()
        {
            //Clears the cards from the form
            removeAllCardBox();
            defaultValues();

            //The player's hand is shown up
            foreach (Card card in players[0].PlayHand)
            {
                cardBoxObject = new CardBox.CardBox();
                cardBoxObject = setCardBoxValues(cardBoxObject, card, true, true, PlayPosX, PlayPosY);
                cardBoxObject.Click += new EventHandler(CardboxTest_Click);

                this.Controls.Add(cardBoxObject);
                cardNumber++;
                PlayPosX += 40;
            }

            //The AI Hand is shown up
            foreach (Card card in players[1].PlayHand)
            {
                cardBoxObject = new CardBox.CardBox();
                cardBoxObject = setCardBoxValues(cardBoxObject, card, true, true, PlayAiPosX, PlayAiPosY);
                this.Controls.Add(cardBoxObject);

                cardNumber++;
                PlayAiPosX += 60;
            }

            //Sets the middle playing cards
            foreach (Card card in cardsDealt)
            {
                cardBoxObject = new CardBox.CardBox();
                cardBoxObject = setCardBoxValues(cardBoxObject, card, true, true, dealtX, dealtY);

                this.Controls.Add(cardBoxObject);

                cardNumber++;
                dealtX += 60;
            }

            //Checks if there is more cards up or not
            if (cardsDealt.Count >= MAX_NUMBER_OF_PLAYING_CARDS)
            {
                lblWarning.Text = "Cannot have anymore cards";
                
            }
            
        }

        /// <summary>
        /// The button that does most of the work the player
        /// - It can start or restart the game
        /// - Make the player collect or discard the cards in play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearCards_Click(object sender, EventArgs e)
        {
            if (btnClearCards.Text.Equals(TAKE_BUTTON))//If button is set to take cardss
            {
                
                DurakLog("\tPlayer chose to take all cards");

                //Sets the player to become the defender and the AI being the Attacker
                if (cardsDealt.Count == 0) { players[0].isAttack = true; players[1].isAttack = false; btnClearCards.Text = DISCARD_BUTTON; }

                showWhoseAttackDefend();

                //Adds the playing cards into the players hands
                foreach (Card card in cardsDealt)
                {
                    players[0].PlayHand.Add(card);
                }

                addMoreCardsToPlayerHands();

                lblWarning.Text = "";
                lblMessage.Text = "";
                
                cardsDealt = new Cards();

                AiStartsNewPlayingCards();
                
            }
            else if (btnClearCards.Text.Equals(DISCARD_BUTTON))//If the button is set to remove the cards
            {
                DurakLog("\tPlayer chose to take discard cards");

                lblMessage.Text = "";
                lblWarning.Text = "";

                //Discards the cards in play
                cardsDealt = new Cards();
                addMoreCardsToPlayerHands();
                setNewCardField();

                //Sets the player to become the defender and the AI being the Attacker
                if (cardsDealt.Count == 0) { players[0].isAttack = false; players[1].isAttack = true; btnClearCards.Text = TAKE_BUTTON; }

                showWhoseAttackDefend();
            }
            else if (btnClearCards.Text.Equals("Restart") || btnClearCards.Text.Equals("Start"))
            {
                removeTrumpImage();
                cardsDealt = new Cards();
                gameSetUp();

            }
            
        }


        /// <summary>
        /// Makes sure that both players gain more cards after each 
        /// defending ends
        /// </summary>
        private void addMoreCardsToPlayerHands()
        {
            for (int c = 0; players[1].PlayHand.Count < PLAYER_STARTING_NUMBER; c++)
            {
                if (currentCard <= playDeck.NumberOfCards-1)
                    players[1].PlayHand.Add(playDeck.GetCard(currentCard++));
                else
                {
                    break;
                }
            }

            for (int c = 0; players[0].PlayHand.Count < PLAYER_STARTING_NUMBER; c++)
            {
                if (currentCard <= playDeck.NumberOfCards - 1)
                    players[0].PlayHand.Add(playDeck.GetCard(currentCard++));
                else
                {
                    break;
                }
            }

        }

        /// <summary>
        /// Lets the AI try to play the next card
        /// </summary>
        private void playAiPlayer()
        {
            int currentCardValue, lastCardDealtValue;

            bool isMoved = false;

            //Sets to the highest value possible, as trump increases the card value and Ace is max
            Card chosenCard = new Card(trumpCard.Suit, Rank.Ace);
            
            foreach (Card card in players[1].PlayHand)
            {
                currentCardValue = card.value;
                lastCardDealtValue = cardsDealt.Last<Card>().value;

                //The system should try to look for a non-trump card to be used, else it tries to look for another
                if (card.suit == trumpCard.Suit) { currentCardValue += 10; } 
                    
                //Checks if the last card on playing field is a Trump
                if (cardsDealt.Last<Card>().suit == trumpCard.Suit) { lastCardDealtValue += 10; }
                    
                //If the card is over the last playing card, then it adds them into the playing cards
                if (currentCardValue >= lastCardDealtValue)
                {
                    //This will allow the if statement later, know if a card has been chosen to be used for play
                    isMoved = true;
                    //Checks if the chosen card is a trump card or not
                    int chosenCardValue = (chosenCard.suit == trumpCard.Suit) ? chosenCard.value + 10 : chosenCard.value;
                    //Checks if it is the least possible card that the AI can choose to play
                    if (currentCardValue < chosenCardValue)
                    {
                        chosenCard = card;
                    }
                } 
            }
                
            //If any card has been chosen to move, then AI would add card to playing field
            if (isMoved)
            {
                DurakLog("\t\tAI Chose to Play (" + chosenCard.ToString() + ") against (" + cardsDealt.Last<Card>().ToString() + ")");
                cardsDealt.Add(chosenCard);
                players[1].PlayHand.Remove(chosenCard);
            }
            else //If AI cannot defeat playing card, then they either take or discard
            {
                //Checks if AI is attacker or not
                if  (players[1].isAttack == true) //AI is attack
                {
                    DurakLog("\t\tAI could not attack last playing field, discards all cards");

                    cardsDealt = new Cards();
                    
                    AiStartsNewPlayingCards();
                }
                else //AI is defend
                {
                    DurakLog("\t\tAI could not defend last playing field, takes all cards");
                    AiGetsAllPlayingCards();

                    if (cardsDealt.Count == 0) { players[0].isAttack = false; players[1].isAttack = true; btnClearCards.Text = "Take Cards"; }

                    showWhoseAttackDefend();

                    addMoreCardsToPlayerHands();
                }
            }
        }


        /// <summary>
        /// When the AI is defending and cannot defend his cards,
        /// it will receive all cards
        /// </summary>
        private void AiGetsAllPlayingCards()
        {
            foreach (Card card in cardsDealt)
            {
                players[1].PlayHand.Add(card);
            }

            addMoreCardsToPlayerHands();

            cardsDealt = new Cards();
        }


        /// <summary>
        /// The AI player will start defending
        /// </summary>
        private void AiStartsNewPlayingCards()
        {
            DurakLog("\tAI Player starts the playing field as Defender");

            int currentCardValue, lowestCardValue = 50;

            Card lowestCard = new Card();

            //Sets the player to attack and the AI is defending
            if (cardsDealt.Count == 0) { players[0].isAttack = true; players[1].isAttack = false; btnClearCards.Text = DISCARD_BUTTON; }

            showWhoseAttackDefend();

            addMoreCardsToPlayerHands();

            //Checks each card to choose from
            foreach (Card card in players[1].PlayHand)
            {
                currentCardValue = card.value;

                //check if current card is a trump
                if (card.suit == trumpCard.Suit) { currentCardValue += 10; } 

                //Checks if the lowest card chosen is a Trump
                if (lowestCard.suit == trumpCard.Suit) { lowestCardValue += 10; }

                //if the current card is less than the lowest card chosen, then the current card becomes the new lowest card chosen
                if (currentCardValue < lowestCardValue)
                {
                    lowestCard = card;
                    lowestCardValue = (int)card.rank;
                    
                }

                //Ends from checking the rest of the hand
            }

            //Lowest card in the AI's hand has been chosen to be played
            DurakLog("\tAI Player chose to play (" + lowestCard.ToString() + ")");

            cardsDealt.Add(lowestCard);

            players[1].PlayHand.Remove(lowestCard);

            setNewCardField();

        }

        /// <summary>
        /// This ends the game with a final game result and lets the player 
        /// choose if they want to play again
        /// </summary>
        private void setWinner()
        {
            //Tries to remove all the cardbox click function
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CardBox.CardBox)
                {
                    controlsToRemove.Add(ctrl);
                }
            }

            foreach (Control ctrl in controlsToRemove)
            {
                ctrl.Click -= new EventHandler(CardboxTest_Click);
            }

            //When both players hands are empty, they draw
            if (players[0].PlayHand.Count == 0 && players[1].PlayHand.Count == 0)
            {
                Properties.Settings.Default.draw += 1;
                DurakLog("Both Players are drawn to a Tie");
                lblMessageAi.Text = "Draw";
                lblMessagePlayer.Text = "Draw";
            }
            else if (players[0].PlayHand.Count == 0) //When the Player Wins
            {
                Properties.Settings.Default.wins += 1;
                DurakLog("The Player Won");
                lblMessageAi.Text = "AI Lose";
                lblMessagePlayer.Text = "You Win";
            }
            else//Else AI wins
            {
                Properties.Settings.Default.lose += 1;
                DurakLog("AI Player Won");
                lblMessageAi.Text = "AI Wins";
                lblMessagePlayer.Text = "You Lose";
            }
            Properties.Settings.Default.Save();

            btnClearCards.Text = "Restart";
        }
        
        
        /// <summary>
        /// This Method is used to write logs into a file
        /// </summary>
        /// <param name="message">Text is entered for the system to add logged information</param>
        public static void DurakLog(String message)
        {
            using (StreamWriter w = File.AppendText("DurakLog.txt"))
            {
                w.WriteLine("{0, 10} {1, 15} | {2}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString(), message);
            }
        }

        /// <summary>
        /// This is when the statistic menu is clicked, 
        /// to show the Statistic Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticForm statisticForm = new StatisticForm();

            statisticForm.Show();
        }
    }
}
