﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSeriesUsingGeneric
{
    internal class LinkedList
    {
        public Node head;
       internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head ==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!= null)
                {
                    temp = temp.next;   
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linklist :",node.data);
            
        }
        internal void display()
        {
            Console.WriteLine("............................................\n");
            Node temp = head;
            if(temp == null) {
                Console.WriteLine("the linked list is empty ");
                return;
            }
            while(temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
    }
}
