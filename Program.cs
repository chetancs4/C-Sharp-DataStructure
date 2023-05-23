namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue

            Node n = new Node();
            n.InsertAtEnd(10);
            n.Display();
            n.InsertAtEnd(20);
            n.Display();
            n.InsertAtEnd(30);
            n.Display();
            n.InsertAtEnd(40);
            n.Display();
            n.InsertAtEnd(50);
            n.Display();

            n.RemoveAtStart();
            n.Display();
            n.RemoveAtStart();
            n.Display();
            n.RemoveAtStart();
            n.Display();
        }
    }
}