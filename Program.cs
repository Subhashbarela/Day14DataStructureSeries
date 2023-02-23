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
            Console.WriteLine(" Insert the element at first position : ");
            int last1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Insert the element at second lastPosition  : ");
            int last2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Insert the element at last position : ");
            int last = Convert.ToInt32(Console.ReadLine());
            list.AddLast(last);
            list.AddLast(last1);
            list.AddLast(last2);
            list.display();

            Console.Read();
        }
    }
}
