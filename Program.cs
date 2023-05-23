using System.Xml.Linq;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stack

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

            n.RemoveAtEnd();
            n.Display();
            n.RemoveAtEnd();
            n.Display();
            n.RemoveAtEnd();
            n.Display();
        }
    }
}