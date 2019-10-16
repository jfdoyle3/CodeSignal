using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeSignal.InterviewPractices
{
    class HouseRobber
    {
        public static void Robber()
        {
          // int[] nums = { 4, 1, 2, 7, 5, 3, 1 }; // ans 14;
           int[] nums = { 1, 1, 1 }; // 2


            List<int> lootbag = new List<int>();
            int house = -1;

            int numLen = nums.Length;
    
            if (numLen==1 && nums[0]==1)
                Console.WriteLine("1");
            if (nums[0] == 0)
                Console.WriteLine("0");

            do
            {
                if(house+1>=numLen-1)
                {
                   break;
                }
                else
                {
                  house++;
                }

                Console.WriteLine("{0} , {1}",nums[house],nums[house+1]);

                if (nums[house] >= nums[house + 1])
                {
                    lootbag.Add(nums[house]);
                     house++;
                }
                  
               
            } while (house != numLen);

            foreach (int item in lootbag)
            {
                Console.WriteLine(item);
            }

            int totalHaul = lootbag.Sum();

            Console.WriteLine("Haul for the Night: {0}",totalHaul);
            //Console.WriteLine("{0} - {1}", house.Key, house.Value); 



        }



    }
}
