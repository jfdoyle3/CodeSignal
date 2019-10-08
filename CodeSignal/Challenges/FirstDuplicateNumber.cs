using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Challenges
{
    class FirstDuplicateNumber
    {
        public static void DupeNumber()
        {
           // int[] array = { 2, 4, 3, 5, 1 };
              int[] array = { 2, 3, 3, 1, 5, 2 };
            int arrLgth = array.Length;
            int cur = arrLgth-1;
            int idx = 0;

            Console.WriteLine("idx  |  indx");


            //  for (int idx = 0; idx < arrLength-1; idx++)
            do
            {
                Console.WriteLine(" {0}   ==  {1}", array[idx-1], array[cur]);
                
                
            } while (idx < arrLgth);
            
            Console.WriteLine("Number: "); // return number;

        }
    }
}
            // for (int indx=1; indx<array.Length; indx++)
            //  {
                    //if (array[idx] == array[indx])
                    //    Console.WriteLine("match");
                    //else
                    //  Console.WriteLine("No Match"); // return -1;

                
             // }