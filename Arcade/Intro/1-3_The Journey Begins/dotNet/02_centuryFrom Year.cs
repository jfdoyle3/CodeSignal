using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Arcade.Intro
{
    class Two_centuryFrom_Year
    {
       public static void centuryFromYear()
        {

            int year = 35100;
            double reducer = .01;
            
            if (year%100==0)
            {

                double decYear = year * reducer;
                Console.WriteLine((int)decYear); 
            }
            else
            {
                double decYear = year * reducer;
                double result = decYear + 1;
                Console.WriteLine((int)decYear);
            }
           
        }
    
    }
}
