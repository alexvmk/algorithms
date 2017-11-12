using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class MaxNearestNumberInArray
    {
        public MaxNearestNumberInArray()
        {
        }

        public int CalcSecondMaxNumber(List<int> inputList)
        {
            if ((inputList == null) || (inputList.Count < 5))
            {
                throw new Exception("Minimum length of teh input array must be greater than 5");
            }

            int maxNumber = Int32.MinValue;
            int maxNumberIndex = -1;
            int secondMaxNumber = Int32.MinValue;
            int secondmaxNumberIndex = -1;
            int thirdMaxNumber = Int32.MinValue;
            int thirdmaxNumberIndex = -1;
            int fourthMaxNumber = Int32.MinValue;
            int fourthmaxNumberIndex = -1;

            var result = 0;
            for (var i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] > maxNumber)
                {
                    maxNumber = inputList[i];
                    maxNumberIndex = i;
                }
                else if (inputList[i] > secondMaxNumber)
                {
                    secondMaxNumber = inputList[i];
                    secondmaxNumberIndex = i;
                }
                else if (inputList[i] > thirdMaxNumber)
                {
                    thirdMaxNumber = inputList[i];
                    thirdmaxNumberIndex = i;
                }
                else if (inputList[i] > fourthMaxNumber)
                {
                    fourthMaxNumber = inputList[i];
                    fourthmaxNumberIndex = i;
                }
            }

            if (Math.Abs(maxNumberIndex - secondmaxNumberIndex) > 1)
                result = secondMaxNumber;
            else if (Math.Abs(maxNumberIndex - thirdmaxNumberIndex) > 1)
                result = thirdMaxNumber;
            else if (Math.Abs(maxNumberIndex - fourthmaxNumberIndex) > 1)
                result = fourthMaxNumber;
            return result;
        }
    }
}
