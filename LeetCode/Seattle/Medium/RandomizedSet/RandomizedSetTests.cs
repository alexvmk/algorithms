using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Seattle.Medium.RandomizedSet
{
    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class RandomizedSetTests
    {
        public RandomizedSetTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test1()
        {
            // Init an empty set.
            RandomizedSet randomSet = new RandomizedSet();

            // Inserts 1 to the set. Returns true as 1 was inserted successfully.
            randomSet.Insert(1);

            // Returns false as 2 does not exist in the set.
            randomSet.Remove(2);

            // Inserts 2 to the set, returns true. Set now contains [1,2].
            randomSet.Insert(2);

            // getRandom should return either 1 or 2 randomly.
            randomSet.GetRandom();

            // Removes 1 from the set, returns true. Set now contains [2].
            randomSet.Remove(1);

            // 2 was already in the set, so return false.
            randomSet.Insert(2);

            // Since 2 is the only number in the set, getRandom always return 2.
            randomSet.GetRandom();

        }
    }    
}
