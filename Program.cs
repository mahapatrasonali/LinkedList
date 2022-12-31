using System.Collections.Generic;

namespace LinkedListDemo
{
    class Program
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome To LinkedList Program ");
            Console.WriteLine("Choose a option from below\n" +
                "Choose 1): Creating a linked list \n " +
                "\nChoose 2) : Creating a linked list \n "
                + "\nChoose 3) : Creating a linked list \n ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LinkedList linkedList = new LinkedList();
                    linkedList.Add(56);
                    
                    linkedList.Add(30);
                    linkedList.Add(70);
                    linkedList.Display();
                    break;
                case 2:
                    linkedList = new LinkedList();
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(56);
                    linkedList.Display();
                    break;
                case 3:
                    linkedList = new LinkedList();
                    linkedList.AppendFirst(56);
                    linkedList.AppendFirst(30);
                    linkedList.AppendFirst(70);
                    linkedList.Display();
                    break;

                default:
                    Console.WriteLine("Choose a Valid Option");
                    break;
            }
        }
    }
}