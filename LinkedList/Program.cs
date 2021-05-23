using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Using Linked List");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            list.RemoveFirstNode();
            list.RemovaLastNode();
            list.Search(56);
            Console.ReadKey();
        }
    }
}
