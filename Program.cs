using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSeriesUsingGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          LinkedList list = new LinkedList();
            Console.WriteLine("inser the element into linked list :");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inser the element into linked list :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inser the element into linked list :");
            int num3 = Convert.ToInt32(Console.ReadLine());
            list.Add(num1);
            list.Add(num2);
            list.Add(num3);
           
            list.display();
            Console.Read();
        }
            
    }
}
