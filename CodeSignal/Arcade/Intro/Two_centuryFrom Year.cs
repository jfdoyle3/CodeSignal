using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Arcade.Intro
{
    class Two_centuryFrom_Year
    {
       public static void centuryFromYear()
        {

            int year = 1992;
            double decYear = year * .01;
            double result = Math.Round(decYear);
            Console.WriteLine((int)result);
        }
    }
}
