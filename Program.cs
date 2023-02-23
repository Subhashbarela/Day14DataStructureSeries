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
           list.AddLast(30);
            list.AddLast(70);
            list.display();
            Console.WriteLine("\n......................");
            
            list.FindElement(56);
           
            Console.Read();
        }
    }
}
