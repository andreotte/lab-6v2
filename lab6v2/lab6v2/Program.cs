
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
            Random rand = new Random();

            Console.WriteLine("enter number of sides: ");
            int sideNumber = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < 10; i++) // Change i < val to change number of random numbers generated
            {
                int output = GetRandom(sideNumber, rand);
                Console.WriteLine(output);
            }


        }

        public static void GetInput()
        {

        }
        public static int GetRandom(int sideNumber, Random rand)
        {
            int number = rand.Next(1, sideNumber + 1);

            return number;
        }

        public static void Roll()
        {

        }      

    }
}