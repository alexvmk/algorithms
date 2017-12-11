using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms2017
{
    public class SortedLinkedList
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
        }

        public void Do()
        {
            var root = new Node { Value = 1 };
            root.Next = new Node { Value = 4 };
            root.Next.Next = root;
            var elem = 6;

            InsertElement(root, elem);
        }

        private void InsertElement(Node root, int elem)
        {
            var current = root;
            do
            {
                if (current.Next == root)
                {
                    current.Next = new Node
                    {
                        Value = elem,
                        Next = root
                    };

                    return;
                }

                if (elem > current.Value && elem <= current.Next.Value)
                {
                    var temp = current.Next;
                    current.Next = new Node
                    {
                        Value = elem,
                        Next = temp
                    };

                    return;
                }

                current = current.Next;

            } while (current != root);
        }
    }
}
