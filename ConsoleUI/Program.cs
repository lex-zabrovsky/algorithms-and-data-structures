using System.Collections.Generic;
using DataStructures;
using Algorithms;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuickFindUF_Client();
        }

        static void QuickFindUF_Client()
        {
            var qf = new QuickFindUF(9);
            Console.WriteLine($"New array: {qf.ToString()}");
            qf.Union(1, 2);
            Console.WriteLine($"Union(1, 2): {qf.ToString()}");
            qf.Union(1, 8);
            Console.WriteLine($"Union(1, 8): {qf.ToString()}");
            qf.Union(0, 7);
            Console.WriteLine($"Union(0, 7): {qf.ToString()}");
            Console.WriteLine($"Connected(2, 8): Expected: True, Actually: {qf.Connected(2, 8)}");
        }

        static void DoublyLinkedList_Client()
        {
            var list = new SinglyLinkedList<float>() { 1.4f, 3.2f, 5.7f };

            Console.WriteLine(list);

            var doublyList = new DoublyLinkedList<string>();
            doublyList.Add("1");
            doublyList.Add("3");
            doublyList.Add("6");
            Console.WriteLine(doublyList);
            foreach (var item in doublyList)
            {
                Console.WriteLine(item);
            }

            doublyList.RemoveAt(1);
            doublyList.RemoveAt(0);

            Console.WriteLine(doublyList);
            
            doublyList.Add("5");
            doublyList.Add("6");
            Console.WriteLine(doublyList);

            doublyList.RemoveAt(1);
            Console.WriteLine(doublyList);

            doublyList.Remove("6");
            Console.WriteLine(doublyList);

            if (doublyList.Remove("6"))
            {
                Console.WriteLine("yes");
            }            
        }
    }
}