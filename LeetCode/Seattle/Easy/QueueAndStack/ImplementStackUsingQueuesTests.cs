using System;
using System.Collections.Generic;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.Easy.QueueAndStack
{
    /// <summary>
    /// https://leetcode.com/problems/implement-stack-using-queues/.
    /// </summary>
    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class ImplementStackUsingQueuesTests
    {
        public ImplementStackUsingQueuesTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            MyStack queue = new MyStack();

            queue.Push(1);
            queue.Push(2);
            Assert.Equal(2, queue.Top());  // returns 1
            Assert.Equal(2, queue.Pop());  // returns 1
            Assert.False(queue.Empty());  // returns false
        }
    }
}
