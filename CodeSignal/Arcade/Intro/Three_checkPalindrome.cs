using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Arcade.Intro
{
    class Three_checkPalindrome
    {

        public static void checkPalindrome()
        {
            string inputString = "cz";
            char[] temp =new char[inputString.Length];
            int letters = inputString.Length-1;

            for (int i=0; i<inputString.Length; i++)
            {
               
               temp[i] = inputString[letters];
                letters--;
            }

            string isPalin = new string(temp);

            if (isPalin==inputString)
                Console.WriteLine("true");
                // return true;
            else
                Console.WriteLine("false");
                // return false;

 
        }

    }
}