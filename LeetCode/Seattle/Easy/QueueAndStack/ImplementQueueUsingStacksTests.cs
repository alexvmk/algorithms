using System;
using System.Collections.Generic;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.Easy.QueueAndStack
{
    /// <summary>
    /// https://leetcode.com/problems/implement-queue-using-stacks/.
    /// </summary>
    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class ImplementQueueUsingStacksTests
    {
        public ImplementQueueUsingStacksTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            MyQueue queue = new MyQueue();

            queue.Push(1);
            queue.Push(2);
            Assert.Equal(1, queue.Peek());  // returns 1
            Assert.Equal(1, queue.Pop());  // returns 1
            Assert.False(queue.Empty());  // returns false
        }
    }
}
