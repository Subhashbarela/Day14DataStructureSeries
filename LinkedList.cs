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
        internal void FindElement(int search)
        {
            Node SearchElem = new Node(search);
            SearchElem = this.head;
            int found = 0;
            int i = - 0;
            if (SearchElem != null)
            {
                while(SearchElem != null)
                {
                   
                    if(SearchElem.data == search)
                    {
                        i++;
                        found++;
                        break;
                    }
                    SearchElem = SearchElem.next;
                }
                if(found == 1)
                {

                    Console.WriteLine(search + " is found at position = " + i + ".");
                }
                else
                {
                    Console.WriteLine(search + " is not found in the list ");
                }

            }
            else
            {
                Console.WriteLine("the list is empty :");
            }


           
        }
    }
}
