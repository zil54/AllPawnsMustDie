using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitDataStructuresDemo
{
    public class DoublyLinkedList<T>
    {
        private Node head;
        private Node tail;

        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
                Prev = null;
            }
        }

        public void AddFirst(T data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;

            if (head != null)
            {
                head.Prev = newNode;
            }
            head = newNode;

            if (tail == null)
            {
                tail = head;
            }
        }

        public void AddLast(T data)
        {
            if (tail == null)
            {
                AddFirst(data);
                return;
            }

            Node newNode = new Node(data);
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        public T RemoveFirst()
        {
            if (head == null) throw new InvalidOperationException("The list is empty");

            T value = head.Data;
            head = head.Next;

            if (head != null)
            {
                head.Prev = null;
            }
            else
            {
                tail = null;
            }

            return value;
        }

        public T RemoveLast()
        {
            if (tail == null) throw new InvalidOperationException("The list is empty");

            T value = tail.Data;
            tail = tail.Prev;

            if (tail != null)
            {
                tail.Next = null;
            }
            else
            {
                head = null;
            }

            return value;
        }

        public Node Find(T data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void PrintDLList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data);
                if (current.Next != null)
                {
                    Console.Write(" <--> ");
                }
                current = current.Next;
            }
            Console.WriteLine();
        }

        // Additional methods like Remove(T data), Clear(), etc. can be added as needed.
    }
}
