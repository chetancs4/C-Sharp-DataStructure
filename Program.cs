using LinkedList;

namespace LinkedListPrac
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Linked List

            Node n = new Node();
            n.InsertAtStart(10);
            n.Display();
            n.InsertAtStart(50);
            n.Display();
            n.InsertAtStart(70);
            n.Display();
            n.InsertAtEnd(30);
            n.Display();
            n.InsertatPosition(2, 38);
            n.Display();

            n.RemoveAtStart();
            n.Display();
            n.RemoveAtEnd();
            n.Display();
            n.RemoveAtPosition(2);
            n.Display();
            n.RemoveAtStart();
            n.Display();
        }
    }
}