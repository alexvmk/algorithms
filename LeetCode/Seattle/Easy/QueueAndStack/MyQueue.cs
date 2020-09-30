using System;
using System.Collections.Generic;
using System.Text;
using Castle.Core.Internal;

namespace Seattle.Easy.QueueAndStack
{
    /// <summary>
    /// https://leetcode.com/problems/implement-queue-using-stacks/.
    /// </summary>
    public class MyQueue
    {
        private readonly Stack<int> s1 = new Stack<int>();
        private readonly Stack<int> s2 = new Stack<int>();
        private int front;

        /** Initialize your data structure here. */
        public MyQueue()
        {

        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if (s1.IsNullOrEmpty())
            {
                front = x;
            }

            s1.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (s2.IsNullOrEmpty())
            {
                while (!s1.IsNullOrEmpty())
                {
                    s2.Push(s1.Pop());
                }
            }

            return s2.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return front;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return s1.IsNullOrEmpty() && s2.IsNullOrEmpty();
        }
    }
}
