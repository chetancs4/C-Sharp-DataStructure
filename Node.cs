using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
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
        //Insert Element at end
        public void InsertAtEnd(int data)   // 1   2    3    4    5    6    7   ----index 
        {                                                               //->push                             
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
        //Remove the element from end
        public void RemoveAtEnd()   // 1   2    3    4    5    6    7   ----index
        {                                                           //-->pop
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
