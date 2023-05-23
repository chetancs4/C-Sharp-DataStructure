using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
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
        public void InsertAtEnd(int data)   // 1   2    3    4    5    6    7   ----index 
        {                                                               //->Enqueue(push)                            
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
        public void RemoveAtStart()         // 1   2    3    4    5    6    7   ----index
        {                                   //<-Dequeue(pop)
            if (head == null)
            {
                return;
            }
            head = head.next;
        }

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
