using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    //链表节点类
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
}
