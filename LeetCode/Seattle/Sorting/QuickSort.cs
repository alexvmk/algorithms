using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Sorting
{
    public class Task4QuickSort
    {
        public int[] SortTest(int[] input)
        {
            QuickSort(input);
            return input;
        }

        private void QuickSort<T>(T[] array) where T : IComparable<T>
        {
            QuickSort(array, array.GetLowerBound(0), array.GetUpperBound(0));
        }

        private void QuickSort<T>(T[] array, int startIndex, int endIndex) where T : IComparable<T>
        {
            if (startIndex >= endIndex) return;

            var partitionIndex = Partition(array, startIndex, endIndex);
            QuickSort(array, startIndex, partitionIndex);
            QuickSort(array, partitionIndex + 1, endIndex);
        }

        private int Partition<T>(T[] array, int start, int end) where T : IComparable<T>
        {
            T pivotValue = array[start];

            int left = start - 1;
            int right = end + 1;

            while (true)
            {

                do
                {
                    left++;
                } while (array[left].CompareTo(pivotValue) < 0);

                do
                {
                    right--;
                } while (array[right].CompareTo(pivotValue) > 0);

                if (left < right)
                {
                    var temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class QuickSortTests
    {
        public QuickSortTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Sort()
        {
            var algorithm = new Task4QuickSort();

            var res = algorithm.SortTest(new int[] { 10, 3, 6, 5, 12, -1 });
            Assert.NotEmpty(res);
            Assert.Equal(res, new int[] { -1, 3, 5, 6, 10, 12});
        }
    }
}
