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
                + "\nChoose 3) : Creating a linked list \n " +
                "\nChoose 4) : Inserted a linked list \n " +
                "\nChoose 5) : Delete First Node from linked list \n " +
                "\nChoose 6) : Delete Last Node from linked list \n " +
                "\nChoose 7) : Search  Node from linked list \n " +
                "\nChoose 8): To Insert An Element After in a linked list \n" +
               "\nChoose 9): To Delete An Element After in a linked list \n");
                
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
                case 4:
                    linkedList = new LinkedList();
                    linkedList.AddFirst(56);
                    linkedList.InsertAdd(1, 30);
                    linkedList.AddFirst(70);
                    linkedList.Display();
                    break;
                case 5:
                    linkedList = new LinkedList();
                    linkedList.AddFirst(56);
                    linkedList.AddFirst( 30);
                    linkedList.AddFirst(70);
                    linkedList.RemoveFirst(56);
                    linkedList.Display();
                        break;
                case 6:
                   linkedList = new LinkedList();
                    linkedList.AddFirst(56);
                    linkedList.AddFirst( 30);
                    linkedList.AddFirst(70);
                    linkedList.RemoveLast(70);
                    linkedList.Display();
                    break;
                case 7:
                    linkedList = new LinkedList();
                    linkedList.AddFirst(56);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(70);
                    linkedList.SearchNode(56);
                    linkedList.Display();
                    break;
                case 8:
                    linkedList = new LinkedList();
                    linkedList.AddFirst(56);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(70);
                    linkedList.InsertAfter(30,40);
                    linkedList.Display();
                    break;
                case 9:
                    linkedList = new LinkedList();
                    linkedList.AddFirst(56);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(40);
                    linkedList.AddFirst(70);
                    linkedList.DeleteFromMiddle(40);
                    linkedList.Display();
                    break;


                default:
                    Console.WriteLine("Choose a Valid Option");
                    break;
            }
        }
    }
}