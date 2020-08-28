/*Chaud Marshall      11/4/15     RockPaperScizzers*/
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* You may ask me why. My awnser will be ,"why not". */
namespace Question_8_RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            int x = 0;
            do
            {
                WriteLine("Choose game mode: Boreing(1) or Smash(2)");
                string gameString = ReadLine();
                int boreing = int.Parse(gameString);/// regular rock,paper,scissors game
                //int smash = int.Parse(gameString);/// awsome rock,paper,scissors game
                switch (boreing)
                {
                    case 1:

                        {
                            WriteLine("____________________________________________");
                            WriteLine("rock, paper, scissors");
                            Random boreingrnd = new Random();
                            int boreingchoice = boreingrnd.Next(1, 4);
                            WriteLine("Enter 'p' for paper, 'r' for rock, and 's' for scissors....  ");
                            string myboreingString = ReadLine();///string for user input
                            char switch1 = char.Parse(myboreingString);
                            char switch2 = char.Parse(myboreingString);
                            char switch3 = char.Parse(myboreingString);

                            switch (switch1)///PAPER
                            {
                                case 'p':/// user chooses paper
                                    switch (boreingchoice)
                                    {
                                        case 1:/// computer chooses paper
                                            WriteLine("you choose paper.");///user results
                                            WriteLine("computer chooses paper.");///computer results
                                            WriteLine(" draw ");/// results in a draw
                                            break;
                                        case 2:/// computer chooses rock
                                            WriteLine("you choose paper.");///user results
                                            WriteLine("computer chooses rock.");///computer results
                                            WriteLine("you win");/// you win
                                            break;
                                        case 3:/// computer chooses scissors
                                            WriteLine("you choose paper.");///user results
                                            WriteLine("computer chooses scissors.");///computer results
                                            WriteLine("computer wins");/// computer wins
                                            break;
                                    }
                                    break;
                            }
                            switch (switch2)///ROCK
                            {
                                case 'r':/// user chooses rock
                                    switch (boreingchoice)
                                    {
                                        case 1:/// computer chooses rock
                                            WriteLine("you choose rock.");///user results
                                            WriteLine("computer chooses rock");///computer results
                                            WriteLine(" draw ");/// results in a draw
                                            break;
                                        case 2:/// computer chooses paper
                                            WriteLine("you choose rock.");///user results
                                            WriteLine("computer chooses paper.");///computer results
                                            WriteLine("computer wins");/// computer win
                                            break;
                                        case 3:/// computer chooses scissors
                                            WriteLine("you choose rock.");///user results
                                            WriteLine("computer chooses scissors.");///computer results
                                            WriteLine("you win");/// user wins
                                            break;
                                    }
                                    break;
                            }
                            switch (switch3)///SCISSORS
                            {
                                case 's':/// user chooses scissors
                                    switch (boreingchoice)
                                    {
                                        case 1:/// computer chooses scissors 
                                            WriteLine("you choose scissors");///user results
                                            WriteLine("computer chooses scissors");///computer results
                                            WriteLine(" draw ");/// results in a draw
                                            break;
                                        case 2:/// computer chooses rock
                                            WriteLine("you choose rock.");///user results
                                            WriteLine("computer chooses rock");///computer results
                                            WriteLine("computer wins.");/// you win
                                            break;
                                        case 3:/// computer chooses paper
                                            WriteLine("you choose scissors");///user results
                                            WriteLine("computer chooses paper.");///computer results);
                                            WriteLine("you win");/// user wins
                                            break;
                                    }
                                    break;

                            }
                            break;
                        }

                    case 2:/// game mode for smash
                        {
                            WriteLine("____________________________________________");
                            WriteLine("Welcome to rock, paper, and SMASH!!!!");
                            WriteLine("Enter your name...");
                            string username = ReadLine();
                            WriteLine("Enter your opponent's name... ");
                            string computername = ReadLine();
                            Random rnd = new Random();
                            int choice = rnd.Next(1, 4);
                            WriteLine("Enter 'p' for paper, 'r' for rock, and 's' for scissors....  ");
                            string myString = ReadLine();///string for user input
                            char switch4 = char.Parse(myString);
                            char switch5 = char.Parse(myString);
                            char switch6 = char.Parse(myString);

                            switch (switch4)///PAPER
                            {
                                case 'p':/// persone chooses the money
                                    switch (choice)
                                    {
                                        case 1:/// computer chooses the money as well
                                            WriteLine(username + " has chosen the money.");///user results
                                            WriteLine(computername + " chose the money too.");///computer results
                                            WriteLine(" No Contest....");/// results in a draw
                                            break;
                                        case 2:/// computer chooses The Rock
                                            WriteLine(username + " chose the money.");///user results
                                            WriteLine(computername + " chose The Rock.");///computer results
                                            WriteLine(" The money creates a rope out of itself and strangles Dwayne Johnson.");
                                            WriteLine(username + " wins!");/// you win
                                            break;
                                        case 3:/// computer chooses Ryūko Matoi's Rending Scissors
                                            WriteLine(username + " chose the money.");///user results
                                            WriteLine(computername + " chose a scissor blade.");///computer results
                                            WriteLine(" {0} uses the scissor blade to slice through the rope made by the money.", computername);
                                            WriteLine(computername + " wins!");/// computer wins
                                            break;
                                    }
                                    break;
                            }
                            switch (switch5)///ROCK
                            {
                                case 'r':/// persone chooses Dwayne Johnson
                                    switch (choice)
                                    {
                                        case 1:/// computer chooses The Rock as well
                                            WriteLine(username + " has chosen Dwayne Johnson.");///user results
                                            WriteLine(computername + " has also chosen Dwayne Johnson but, there can only be one 'Rock' so {0} chooses John Cena.", computername);///computer results
                                            WriteLine(" No Contest....");/// results in a draw
                                            break;
                                        case 2:/// computer chooses the money
                                            WriteLine(username + " chose the The Rock.");///user results
                                            WriteLine(computername + " chose the money.");///computer results
                                            WriteLine(" The money creates a rope out of itself and strangles Dwayne Johnson.");
                                            WriteLine(computername + " wins!");/// computer win
                                            break;
                                        case 3:/// computer chooses Ryūko Matoi's Rending Scissors
                                            WriteLine(username + " chose Dwayne Johnson.");///user results
                                            WriteLine(computername + " chose a scissor blade.");///computer results
                                            WriteLine(" The Rock rips the blade in half.");
                                            WriteLine(username + " wins!");/// user wins
                                            break;

                                    }
                                    break;
                            }
                            switch (switch6)///SCISSORS
                            {
                                case 's':/// persone chooses Rending Scissors
                                    switch (choice)
                                    {
                                        case 1:/// computer chooses the scissors as well
                                            WriteLine(username + " has chosen the scissor blade.");///user results
                                            WriteLine(computername + " chose a keyblade?");///computer results
                                            WriteLine(" No Contest....");/// results in a draw
                                            break;
                                        case 2:/// computer chooses The Rock
                                            WriteLine(username + " uses The Rending Scissors.");///user results
                                            WriteLine(computername + " chose The Rock but, Dwayne Johnson is too tired to participate so Chuck Norris takes his plac.");///computer results
                                            WriteLine(" Chuck Norris destroys the blade with his beard fist, then finishes it with a roundhouse kick TO THE FACE... I mean blade.");
                                            WriteLine(computername + " wins!");/// you win
                                            break;
                                        case 3:/// computer chooses money
                                            WriteLine(username + " stole Ryūko Matoi's scissor blade.");///user results
                                            WriteLine(computername + " ran out of money so {0} started using YuGiOh cards.", computername);///computer results
                                            WriteLine(" {0} used a scissor blade dipped in a elixer of bad-Azzness to slice through Exodia The Forbidden One.", username);
                                            WriteLine(username + " wins!");/// user wins                                     
                                            break;
                                    }
                                    break;
                            }
                        }
                        break;
                     }

                //ReadLine();
                
                }while (x < 5); 
            
            }
        }
}