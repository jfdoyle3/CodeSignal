using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeSignal.Company_Challenges.CodeSignal
{
    class CompanyBotStrategy
    {
        public static void Bot()
        {
            int[,] trainingData = new int[,]
               {{3, 1},
                {6, 1},
                {4, 1},
                {5, 1}};

            double solved, numBots, result;
            int arrLen = trainingData.Length/2;
            List<int> solvedBots = new List<int>();

            for (int index = 0; index < arrLen; index++)
            {
                if (trainingData[index, 1] == 1)
                    solvedBots.Add(trainingData[index,0]);   
            }

            solved = solvedBots.Sum();
            numBots = solvedBots.Count();
            result = solved / numBots;

            bool noBots = Double.IsNaN(result);
            if (noBots)
                Console.WriteLine("0");
            else
                Console.WriteLine(result.ToString("N2"));
        }
    }
}
