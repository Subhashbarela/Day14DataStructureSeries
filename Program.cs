using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            
            list.AddLast(56);
           // list.AddLast(last1);
            list.AddLast(70);
            list.display();

            list.InterAtPosition(2, 30);
            list.display();
            Console.Read();
        }
    }
}
