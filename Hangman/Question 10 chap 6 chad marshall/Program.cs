/// chad marshall chap 6 question 10 hangman
using System;
using static System.Console;
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to meh Hangman! ");///greeting
            string[] wordBank = { "sheep", "handful", "ihateprogramming", "seventy", "watermeloooon","squishy", "litter", "pineapple", "starwars" };/// the word bank
            int p = 0; int j = 0;/// my special varaibles
            bool correct = false;/// sets my correct var to false
            Random randGen = new Random();/// random word gen
            var idx = randGen.Next(0, 9); /// more of my random word gen
            string mysteryWord = wordBank[idx];///looks into my word bank and finds a word
            char[] guess = new char[mysteryWord.Length];///  var for the hidden word
            WriteLine("If the game is on round one, press any letter to show hidden letters");/// tip for first round
            WriteLine("________________________________________________");/// separation line
            for (p = 0; p < mysteryWord.Length; p++)/// for loop for hidden word
                guess[p] = '*';/// hides word with '*'
            while (true)/// my while loop
            {
                WriteLine("Enter a letter");// asks for user input
                char playerGuess = char.Parse(ReadLine());
                for (j = 0; j < mysteryWord.Length; j++)/// for loop for if the user guesses right
                {
                    if (playerGuess == mysteryWord[j]) /// if statment for if the guess matched hidden letters
                    {
                        guess[j] = playerGuess;/// replaces '*' with letter
                        correct = true;/// sets correct to true
                    }
                }
                if (correct == true)/// sets correct to true
                {
                    WriteLine("correct");/// displays message to user
                    correct = false;/// resets correct
                }
                else
                    WriteLine("WRONG");// if guess is wrong, displays wrong
                WriteLine(guess);/// displays guess
            }
        }
    }
}
