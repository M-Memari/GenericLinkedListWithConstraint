using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericLinkedListWithConstraint
{
    public class LinkedList<T> : IEnumerable<T> 
        where T : Employee       
    {
        private class Node
        {
            public Node(T tData) => (NextNode, Data) = (null, tData);
            public Node NextNode { get; set; }
            public T Data { get; private set; }
        }

        private Node _head;

        public void AddEmployee(T t)
        {
            var n = new Node(t){NextNode = _head};
            _head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T FindFirstOccurence(string s)
        {
            Node current = _head;
            T tEmployee = null;
            while (current != null)
            {
                if (current.Data.Name == s)
                {
                    tEmployee = current.Data;
                    break;
                }

                current = current.NextNode;
            }

            return tEmployee;
        }
    }
}
