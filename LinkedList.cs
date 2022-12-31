using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListDemo
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void AddFirst(int data)
        {
            Node newnode = new Node(data);
            newnode.next = head;
            head = newnode;
            Console.WriteLine("{0} added into linked list", newnode.data);
        }
        public void AppendFirst(int data)
        {
            Node node1 = new Node(data);
            node1.next = head;
            head = node1;
            Console.WriteLine("{0} appended into linked list", node1.data);
        }
        public void InsertAdd(int position, int data)
        {
            Node node2 = new Node(data);
            node2.next = head;
            head = node2;
            Console.WriteLine("{0} inserted into linked list ", node2.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
