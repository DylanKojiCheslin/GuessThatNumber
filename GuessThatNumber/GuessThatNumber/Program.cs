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
            Console.WriteLine();
        }
        static void game() 
        {
            int numAttempts = 0;
            stateInstructions();

            //gets input
            string input = Console.ReadLine();
            //if statment does you want to play
            Console.WriteLine("if you wannt to quit type \"I am a coward \"");
            if (input.ToLower() == "i am a coward")
            {

            }
            //elseif giberish restate instruction
            //elseif no then Application.Exit();
            //if yes then game on
            //
        }
        static void Main(string[] args)
        {
            bool wants = true;
            //while loop calling game
            while (wants = true)
            {
                game();
            }
            //state instructions

            



            Console.ReadKey();
        }
    }
}
