using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Arcade.Intro
{
    class Five_shapeArea
    {
        public static void ShapeArea()
        {
            int n = 1;
            int count = 0;
            int max = 2 * n - 1;
            int[] tally = new int[7];


            for (int i=1; i<n; i++)
            {
                Console.WriteLine(2*i-1);
                int odd = 2 * i - 1;
                count +=odd*2;
            }
            count += max;
            Console.WriteLine(count);
        }
    }
}
