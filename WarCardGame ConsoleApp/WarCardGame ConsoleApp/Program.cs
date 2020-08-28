using System;/// chad marshall    question 11 part a            war card game      5/2/2016
using static System.Console;/// make sure to press enter when your start
namespace WarCardGame/// i could not figure out the GUI part of it. ill send my sad attempts too so i maybe can get partial credit...
{
    class Program
    {   
        static int[] deck = new int[52]; // array for the deck
        static string[] cards = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" }; // card values
        static string[] suits = { "spades", "hearts", "diamonds", "clubs" }; // card archetypes
        static Random random = new Random(); // the random engine
        static int cardCount = 0; // sets the var that counts the cards to 0
        static void Main(string[] args)
        {
            WriteLine("press enter to start the game");
            int i, clearCount; // declares the thing that clears the count...
            int num, playerNum, computerNum, computerTotal, playerTotal;/// declares player var
            string computerSuit, playerSuit, computerCard, playerCard;
            i = computerTotal = playerTotal = clearCount = 0;
            FillDeck();// calling the method that does all of the math
            for (i = 0; i < 26; i++)// loop for counting the cards
            {
                ReadLine();
                if (clearCount % 4 == 0)
                {
                    Clear();// clears the cache that keep tracks of the counting
                }
                num = SelectCard() - 1;// sets num to the method select a card
                computerNum = (num - 1) / 4;// sets computers number to number minus uno
                computerCard = cards[computerNum];// sets computer card to equal the cards             
                if (computerNum % 4 == 1) // TON OF IF STATEMENTS
                {
                    computerSuit = suits[0];
                }
                else if (computerNum % 4 == 2)
                {
                    computerSuit = suits[1];
                }
                else if (computerNum % 4 == 3)
                {
                    computerSuit = suits[2];
                }
                else
                {
                    computerSuit = suits[3];
                }
                num = SelectCard() - 1;// sets the number to the method selectcard
                playerNum = (num - 1) / 4;// sets the players number to equal the number minus 1
                playerCard = cards[playerNum];/// sets player card to cards               
                if (playerNum % 4 == 1)// MORE IF STATEMENTS
                {
                    playerSuit = suits[0];
                }
                else if (playerNum % 4 == 2)
                {
                    playerSuit = suits[1];
                }
                else if (playerNum % 4 == 3)
                {
                    playerSuit = suits[2];
                }
                else
                {
                    playerSuit = suits[3];
                }
                switch (computerNum)/// and a random switchcase statement
                {
                    case 1:
                        computerCard = cards[computerNum];
                        break;
                    case 2:
                        computerCard = cards[computerNum];
                        break;
                    case 3:
                        computerCard = cards[computerNum];
                        break;
                    case 4:
                        computerCard = cards[computerNum];
                        break;
                }
                if (playerNum > computerNum)  // more ifs...
                {
                    playerTotal += 2;
                }
                else if (playerNum < computerNum)
                {
                    computerTotal += 2;
                }
                else
                {
                    playerTotal++;
                    computerTotal++;
                }/// and finally the output
                Write("Deal #{0} Computer has {1} of {2}. Player has {3} of {4}\n. Computer score is {5}. Player score is {6}", (i + 1), cards[computerNum], computerSuit, cards[playerNum], playerSuit, computerTotal, playerTotal);
                clearCount++; //.. that repeats 25 more times........
            }   
            WriteLine("\nComputer's total score: {0}", computerTotal);//displays computers total
            WriteLine("Players's total score: {0}\n", playerTotal);// siplays players total            
            if (playerTotal > computerTotal)/// more ifs
            {
                WriteLine("Player Wins!");/// player wins
            }
            else if (playerTotal < computerTotal)
            {
                WriteLine("Computer Wins!");// computer wins
            }
            ReadLine();/// almost forgot this readline
        }
        static void FillDeck()
        {
            bool cardFound = false;// yay bools
            int card;
            for (int i = 0; i < deck.Length; i++)
            {
                cardFound = false;
                while (cardFound == false)
                {
                    card = random.Next(1, 53);
                    if (Array.IndexOf(deck, card) == -1)
                    {
                        deck[i] = card;
                        cardFound = true;
                    }
                }
            }
        }
        static int SelectCard()
        {
            int card = deck[cardCount];
            cardCount++;
            return card;
        }
    }
}