
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;

            // Loop if user wants to roll again.
            while (play)
            {
                Random rando = new Random();
                GetInput(rando);
                Console.WriteLine("Would you like to play again? (y/n)");
                string continuePlaying = Console.ReadLine().ToLower();

                if (continuePlaying == "no" || continuePlaying == "n")
                {
                    play = false;
                }
            }
        }

        // Method to get dice side number and number of dice from user
        public static void GetInput(Random rand)
        {
            int sideNumber;
            int diceNumber;

            Console.WriteLine("Enter number of sides each dice will have: ");            
            string sides = Console.ReadLine();
            int.TryParse(sides, out sideNumber);
            Console.WriteLine("Enter the number of dice you want to roll: ");
            string dice = Console.ReadLine();
            int.TryParse(dice, out diceNumber);

            // Re-run GetInput() when invalid user input
            if (sideNumber == 0 || diceNumber == 0)
            {
                Console.WriteLine("Invalid input. Enter sides and dice number as integers.");
                GetInput(rand);
            }
            else
            {
                string results = Roll(sideNumber, diceNumber, rand);
                Console.WriteLine(results);
            } 
        }

        // Method to generate a random number.
        public static int GetRandom(int max, Random rand)
        {
            int number = rand.Next(1, max + 1);
            return number;
        }

        // Method to roll dice and print rolls results to the console.
        public static string Roll(int sides, int dice, Random rand)
        {
            int total = 0;
            int output;
            string results = "";

            for (int i = 0; i < dice; i++) 
            {
                output = GetRandom(sides, rand);
                results += ($"Die roll #{i + 1}: {output}\n");
                total += output;
            }
            Console.WriteLine($"The total is: {total}");
            return results;
        }      
    }
}