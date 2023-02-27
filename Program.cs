using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);

            list.Print();
            list.InsertAfter(30,40);
            list.Print();
            list.Delete(40);
            list.Print();

            // list.Delete(70);
           


        }
    }
}
