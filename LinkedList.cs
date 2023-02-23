using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListSeries
{
    internal class LinkedList
    {
        public Node head;
        internal void AddLast(int last)
        {
            Node LastNode = new Node(last);

            if (this.head == null)
            {
                this.head = LastNode;

            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = LastNode;
            }
            Console.WriteLine("{0} inserted into linklist :", LastNode.data);
        }

        internal void display()
        {
            Console.WriteLine("............................................\n");
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("the linked list is empty ");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void DeleteFirstElement()
        {
            //Node delete = new Node(head);
            if(this.head !=null)
            {
                Node temp = this.head;
                this.head=this.head.next;
                temp = null;
            }


           
        }
    }
}
