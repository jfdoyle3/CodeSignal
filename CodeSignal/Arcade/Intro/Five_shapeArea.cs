using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Arcade.Intro
{
    class Five_shapeArea
    {
        public static void ShapeArea()
        {
            int n = 4;
            int count = 0;
            int[] tally = new int[7];
            // need to get odd numbers
            if (n == 1)
            {
                Console.WriteLine(n);
            }
            for (int i=1; i<4; i++)
            {
                Console.WriteLine(i + i) ;
            }

        }
    }
}
