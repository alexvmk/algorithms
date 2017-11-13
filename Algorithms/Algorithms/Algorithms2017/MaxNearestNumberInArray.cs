using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class MaxNearestNumberInArray
    {
        public MaxNearestNumberInArray()
        {

        }

        int maxNumber = Int32.MinValue;
        int maxNumberIndex = -1;
        int secondMaxNumber = Int32.MinValue;
        int secondmaxNumberIndex = -1;
        int thirdMaxNumber = Int32.MinValue;
        int thirdmaxNumberIndex = -1;
        int fourthMaxNumber = Int32.MinValue;
        int fourthmaxNumberIndex = -1;

        public int CalcSecondMaxNumber(List<int> inputList)
        {
            if ((inputList == null) || (inputList.Count < 5))
            {
                throw new Exception("Minimum length of teh input array must be greater than 5");
            }

            var result = 0;
            for (var i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] > maxNumber)
                {
                    RecalcValuesOfMazValues(1);
                    maxNumber = inputList[i];
                    maxNumberIndex = i;
                }
                else if (inputList[i] > secondMaxNumber)
                {
                    RecalcValuesOfMazValues(2);
                    secondMaxNumber = inputList[i];
                    secondmaxNumberIndex = i;
                }
                else if (inputList[i] > thirdMaxNumber)
                {
                    RecalcValuesOfMazValues(3);
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

        private void RecalcValuesOfMazValues(int level)
        {
            if (level >= 1 && level <= 3)
            {
                fourthMaxNumber = thirdMaxNumber;
                fourthmaxNumberIndex = thirdmaxNumberIndex;
            }

            if (level >= 1 && level <= 2)
            {
                thirdMaxNumber = secondMaxNumber;
                thirdmaxNumberIndex = secondmaxNumberIndex;
            }

            if (level == 1)
            {
                secondMaxNumber = maxNumber;
                secondmaxNumberIndex = maxNumberIndex;
            }
        }
    }
}
