using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core.Internal;

namespace Seattle.Easy.QueueAndStack
{
    /// <summary>
    /// https://leetcode.com/problems/implement-stack-using-queues/.
    /// </summary>
    public class MyStack
    {
        private readonly Queue<int> q1 = new Queue<int>();

        /** Initialize your data structure here. */
        public MyStack()
        {

        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            q1.Enqueue(x);
            var size = q1.Count();

            while (size > 1)
            {
                q1.Enqueue(q1.Dequeue());
                size--;
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return q1.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return q1.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return q1.IsNullOrEmpty();
        }
    }
}
