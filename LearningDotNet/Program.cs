using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningArrays
{
    class Program
    { 
        static void Main(string[] args)
        {
            {
                string[] colors = { "Red", "Blue", "Green", "Yellow", "White" };
                for (int i = 0; i < colors.Length; i++)
                {
                    Console.WriteLine(colors[i]);
                }

                int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; ;
                for (int i = numbers.Length; i-- > 0;)

                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
