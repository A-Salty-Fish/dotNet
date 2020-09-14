using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> h;
            h = head;
            if (h == null) { throw new Exception("Empty List."); }
            else
            {
                while (h != null)
                {
                    action(h.Data);
                    h = h.Next;
                }
            }
        }
    }
}
