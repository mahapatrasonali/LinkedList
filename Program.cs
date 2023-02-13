using System.Collections.Generic;

namespace LinkedListDemo
{
    class Program
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome To ");
            Console.WriteLine("Choose a option from below\n" +
                "Choose 1): Creating a linked list ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LinkedList linkedList = new LinkedList();
                    linkedList.Add(56);
                    linkedList.Add(30);
                    linkedList.Add(30);
                    linkedList.Add(70);
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("Choose a Valid Option");
                    break;
            }
        }
    }
}