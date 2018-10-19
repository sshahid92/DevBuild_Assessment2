using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSecondDimension_ShahShahid
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[,]
            {
                {5, -4, 3, 0 },
                {5, 1, -2, -1 },
                {8, 6, -7, 4 },
                {-2, 1, -5, 2 }
            };

            int diagSum = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(0); j++)
                {
                    if(i == j)
                    { diagSum =+ numbers[i, j]; }
                }
            }

            int sum = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(0); j++)
                {
                    sum += numbers[i, j];
                }
            }
            Console.WriteLine($"The sum of the diagonal numbers is {diagSum}");
            Console.WriteLine($"The sum of the whole array is {sum}");
            Console.ReadLine();
        }
    }
}
