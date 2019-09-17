using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Company_Challenges.PureStorage
{
    class _1_longestUncorruptedSegement
    {
        public  int[] longestUncorruptedSegment(int[] sourceArray, int[] destinationArray)
        {

            int[] uncorruptedSegment = new int[2];
            int uncorruptedBlocks = 0;
            int startingBlock = 0;
            int longestStartingBlock = 0;
            int longestSegment = 0;

            for (int element = 0; element < sourceArray.Length; element++)
            {

                if (sourceArray[element] != destinationArray[element])
                {
                    if (uncorruptedBlocks > longestSegment)
                    {
                        longestSegment = uncorruptedBlocks;
                        longestStartingBlock = startingBlock;
                        uncorruptedSegment[0] = longestSegment;
                        uncorruptedSegment[1] = longestStartingBlock;
                    }

                    uncorruptedBlocks = 0;
                    continue;
                }
                else
                {
                    if (uncorruptedBlocks < 1)
                    {
                        startingBlock = element;
                    }
                    uncorruptedBlocks++;
                }
                if (uncorruptedBlocks > longestSegment)
                {
                    longestSegment = uncorruptedBlocks;
                    uncorruptedSegment[0] = longestSegment;
                    uncorruptedSegment[1] = startingBlock;
                }
            }
            return uncorruptedSegment;
        }
    }
}
