using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/pascals-triangle/ .
    /// </summary>
    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> triangle = new List<IList<int>>();

            // First base case; if user requests zero rows, they get zero rows.
            if (numRows == 0)
            {
                return triangle;
            }

            // Second base case; first row is always [1].
            triangle.Add(new List<int>());
            triangle[0].Add(1);

            for (int rowNum = 1; rowNum < numRows; rowNum++)
            {
                List<int> row = new List<int>();
                List<int> prevRow = triangle[rowNum - 1].ToList();

                // The first row element is always 1.
                row.Add(1);

                // Each triangle element (other than the first and last of each row)
                // is equal to the sum of the elements above-and-to-the-left and
                // above-and-to-the-right.
                for (int j = 1; j < rowNum; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }

                // The last row element is always 1.
                row.Add(1);

                triangle.Add(row);
            }

            return triangle;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class PascalTriangleTests
    {
        public PascalTriangleTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new PascalTriangle();
            var listOfLists = algorithm.Generate(5);

            // Input: 5
            // Output:
            // [
            //     [1],
            //    [1,1],
            //   [1,2,1],
            //  [1,3,3,1],
            // [1,4,6,4,1]
            // ]

            Assert.Equal(listOfLists[0], new List<int>() { 1 });
            Assert.Equal(listOfLists[1], new List<int>() { 1, 1 });
            Assert.Equal(listOfLists[2], new List<int>() { 1, 2, 1 });
            Assert.Equal(listOfLists[3], new List<int>() { 1, 3, 3, 1 });
            Assert.Equal(listOfLists[4], new List<int>() { 1, 4, 6, 4, 1 });
        }
    }
}
