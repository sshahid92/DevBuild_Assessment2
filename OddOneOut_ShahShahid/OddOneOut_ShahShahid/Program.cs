using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOneOut_ShahShahid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int userInput;
            while (true)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out userInput);

                if (!isNumber)
                {
                    Console.WriteLine("Enter an integer!");
                    continue;
                }
                break;
            }
            int countOddNumbers = 0;
            for (int i = 0; i < userInput; i++)
            {
                if (i % 2 != 0)
                {
                    countOddNumbers++;
                }
            }
            int oddIndex = 0;
            int[] oddNumbers = new int[countOddNumbers];
            for (int i = 0; i < userInput; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers[oddIndex] = i;
                    oddIndex++;
                }
            }

            ListNumber(oddNumbers, userInput);
            Sum(oddNumbers, userInput);
            Average(oddNumbers, userInput);
            Console.ReadLine();
        }

        static void ListNumber(int[] array, int number)
        {
            Console.WriteLine($"All the odd numbers from 1 to {number} are ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }


        static void Sum (int[] array, int number)
        {
            Console.WriteLine($"The sum of all the odd numbers from 1 to {number} is {array.Sum()}.");
        }


        static void Average(int[] array, int number)
        {
            Console.WriteLine($"The average of all the odd numbers from 1 to {number} is {array.Average()}.");
        }
    }
}
