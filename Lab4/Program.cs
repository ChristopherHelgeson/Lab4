using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";
            while (cont == "y" || cont == "Y")
            {
                Console.Clear();
                Console.WriteLine("Welcome to Factorial Calculator!\n");
                Console.Write("Enter an integer that's greater than 0 but less than 21: ");
                int userNum = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\nThe factorial of " + userNum + " is " + factorialMethod(userNum) + ".\n");

                Console.Write("Play again? (Y/N): ");
                cont = Console.ReadLine();
                Console.WriteLine();
            }
        }

        public static long factorialMethod(int passedInt)
        {
            long factNum = 1;
            Console.Write("\n" + passedInt +"! = ");
            for (int i = 1; i <= passedInt; i++)
            {
                factNum = i * factNum;
                Console.Write(i);
                if (i < passedInt)
                {
                    Console.Write(" x ");
                }
                else
                {
                    Console.Write(" = " + factNum);
                }
            }
            return factNum;
        }
    }
}
