using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Arcade.TheCore
{
    class AddTwoDigits
    {
        public static void AddingDigits()
        {
            int n = 29;
            int total = 0;
            string numbers = n.ToString();
            numbers.Split("");
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = (int)Char.GetNumericValue(numbers[i]);
                total += number;
            }
            Console.WriteLine(total);
        }
    }
}
