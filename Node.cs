using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node head;

        public Node(int x)
        {
            data = x;
            next = null;
        }
        public Node()
        {

        }

        //Insert element at start
        public void InsertAtStart(int data)
        {
            Node newnode = new Node(data); // 1   2    3    4    5    6    7   ----index
            if (head == null)              //10 ->
            {
                head = newnode;
            }
            else
            {
                newnode.next = head;
                head = newnode;
            }
        }

        //Insert element at the end
        public void InsertAtEnd(int data)   
        {                                  
            Node temp = head;
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
        }

        //Insert at position
        public void InsertatPosition(int position, int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                return;
            }

            if (position == 1 || head == null)
            {
                InsertAtStart(data);
                return;
            }

            Node previous = null;
            Node temp = head;
            int count = 1;
            while (temp != null && count < position)
            {
                previous = temp;
                temp = temp.next;
                count++;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            previous.next = newnode;
            newnode.next = temp;
        }

        //Remove element from start
        public void RemoveAtStart()
        {
            if (head == null)
            {
                return;
            }
            head = head.next;
        }

        //Remove Element at the end
        public void RemoveAtEnd()
        {
            if (head == null)
            {
                return;
            }
            Node previous = null;
            Node temp = head;

            while (temp.next != null)
            {
                previous = temp;
                temp = temp.next;
            }
            previous.next = null;
        }

        // Remove element at position
        public void RemoveAtPosition(int position)
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
                RemoveAtStart();
                return;
            }

            Node previous = null;
            Node temp = head;
            int count = 1;

            while (temp != null && count < position)
            {
                previous = temp;
                temp = temp.next;
                count++;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            previous.next = temp.next;
        }

        //Display method 
        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
