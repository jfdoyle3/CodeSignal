using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Challenges
{
    class FirstDuplicateNumber
    {
        public static void DupeNumber()
        {
            // https://app.codesignal.com/challenge/yzcgNgQZHYkQrAfcR
            //
            // int[] array = { 2, 4, 3, 5, 1 };
           // int[] intArray = { 2, 3, 3, 1, 5, 2 };
           int[] intArray = { 2, 4, 3, 1, 5, 1 };
            int arrLgth = intArray.Length;
            int oIdx=0;
            int[] result = { 0 };
            //List<int> result = new List<int>();

            Dictionary<int, int> arrLayout = new Dictionary<int, int>();

            //Console.WriteLine("Key  |  Value");
            for (int index = 0; index < arrLgth; index++)
             //   foreach (KeyValuePair<int, int> item in arrLayout)
                {
                if (arrLayout.ContainsKey(intArray[index]))
                {
                  //  Console.WriteLine("oIdx: {0}  | index: {1}",arrLayout[intArray[index]],index);
                    arrLayout[intArray[index]] = index+index;
                   
                    
                }
                else
                    arrLayout.Add(intArray[index], 0);
            }
           
            foreach (KeyValuePair<int, int> item in arrLayout)
            {
                if (item.Value > 1 && oIdx==1 )
                {
                    Console.WriteLine(" {0}   ==  {1}", item.Key, item.Value);
                    oIdx++;
                    Console.WriteLine("I'm more than 0 | count: {0}",oIdx);
                    result[0]=item.Key;
                }

            }
            // Console.WriteLine("arrl: {0}",arrLayout.Count);
            Console.WriteLine("dupe: {0}",result[0]);



        }
    }
}
