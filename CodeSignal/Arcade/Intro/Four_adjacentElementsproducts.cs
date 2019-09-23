using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Arcade.Intro
{
    class Four_adjacentElementsProducts
    {
        public static void adjacentElementsProduct()
        {
            int[] inputArray = new int[] { 3, 6, -2, -5, 7, 3 };
            int[] results = new int[inputArray.Length - 1];

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                results[i] = inputArray[i] * inputArray[i + 1];
            }
            Array.Sort(results);
            Array.Reverse(results);
            Console.WriteLine(results[0]);
            //return results[0];
        }
    }
}
