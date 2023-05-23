using System;

class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    class LinkedList<T> where T : IComparable<T> 
    {
        private Node<T> head;

        public void InsertAtStart(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
            Console.WriteLine("Inserted {0} at the start of the list", data);
        }

        public void InsertAtEnd(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            Console.WriteLine("Inserted {0} at the end of the list", data);
        }

        public void InsertAtPosition(T data, int position)
        {
        if (position == 0)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (position == 1 || head == null)
            {
                InsertAtStart(data);
                return;
            }

            Node<T> newNode = new Node<T>(data);
            Node<T> previous = null;
            Node<T> current = head;
            int count = 1;

            while (current != null && count < position)
            {
                previous = current;
                current = current.Next;
                count++;
            }

            if (current == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            previous.Next = newNode;
            newNode.Next = current;
            Console.WriteLine("Inserted {0} at position {1} of the list", data, position);
        }

        public void DeleteFromStart()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            head = head.Next;
        }

        public void DeleteFromEnd()
        {
            int deletedData = 0;
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.Next == null)
            {
                head = null;
                return;
            }

            Node<T> current = head;
            Node<T> previous = null;

            while (current.Next != null)
            {
                previous = current;
                current = current.Next;
            }

            previous.Next = null;
        }

        public void DeleteAtPosition(int position)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (position <= 0)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            if (position == 1)
            {
                DeleteFromStart();
                return;
            }

            Node<T> previous = null;
            Node<T> current = head;
            int count = 1;

            while (current != null && count < position)
            {
                previous = current;
                current = current.Next;
                count++;
            }

            if (current == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            previous.Next = current.Next;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node<T> current = head;
            Console.Write("Linked List: ");

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

        linkedList.InsertAtEnd(10);
        linkedList.Display();
        linkedList.InsertAtStart(20);
        linkedList.Display();
        linkedList.InsertAtEnd(30);
        linkedList.Display();
        linkedList.InsertAtPosition(40, 2);
        linkedList.Display();

        linkedList.DeleteFromEnd();
        linkedList.Display();
        linkedList.DeleteFromStart();
        linkedList.DeleteAtPosition(2);
        linkedList.Display();

            Console.ReadLine();
        }
    }
