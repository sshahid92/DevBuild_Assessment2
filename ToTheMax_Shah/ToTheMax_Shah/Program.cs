using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheMax_Shah
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How big do you want your array?");
            int arraySize;
            while (true)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out arraySize);

                if (!isNumber)
                {
                    Console.WriteLine("Enter an integer!");
                    continue;
                }
                break;
            }

            int[] userNumbers = new int[arraySize];
            int i=0;
            foreach (int number in userNumbers)
            {
                Console.WriteLine("Enter an integer");
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

                userNumbers[i] = userInput;
                i++;

            }

            
            Console.WriteLine($"The largest number you entered is {userNumbers.Max()}! Great Job!\nPress enter to leave.");
            Console.ReadLine();
        }
    }
}
