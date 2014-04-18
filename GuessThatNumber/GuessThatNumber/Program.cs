using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void stateInstructions() 
        {
            Console.WriteLine("if you want to play type a number between 1 and 100 and hit enter.");
            Console.WriteLine("If you guess right you win.");
            Console.WriteLine("or if you wannt to quit type \"I am a coward \"");
            Console.WriteLine();
        }
        static bool game()
        {
            int numAttempts = 0;
            stateInstructions();
            var r = new Random();
            int anwser = r.Next(1, 101);
            bool hasQuit = false;
            while(!hasQuit)
            {
                //gets input
                string input = Console.ReadLine();
                if (input.ToLower() == "i am a coward")
                {
                    //elseif giberish restate instruction
                    //if yes then game on
                    hasQuit = true;
                    break;
                }
                else if (input=="")//
                {
                    continue;
                }
                //need to prevent string input
                /*else
                {
                    Console.WriteLine("read the instructions");
                    continue;
                }*/
                int numGuess = Convert.ToInt32(input);
                numAttempts++;
                //if statment does you want to play
                
            
                if (numGuess == anwser)
                {
                    Console.WriteLine("You are the winner! Good Job!");
                    Console.WriteLine("It only took "+numAttempts+" trys");
                    break;
                }
                else if (numGuess > anwser)
                {
                    Console.WriteLine("your guess is too high");
                }
                else if (numGuess < anwser)
                {
                    Console.WriteLine("your guess is too low");
                }
                else
                {
                    Console.WriteLine("read the instructions");
                }
            }
            return hasQuit;
        }
        static void Main(string[] args)
        {
            bool done = false;
            //while loop calling game
            while (done == false)
            {
                done = game();
            }
        }
    }
}
