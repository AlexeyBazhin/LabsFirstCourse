using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрационная программа:\n");
            MyLinkedList list = new MyLinkedList(0);
            PrintList(list);
            Console.WriteLine("\nДобавить элемент\n");
            list.Add(10);
            PrintList(list);
            Console.WriteLine("\nУдалить элемент\n");
            list.Remove(1, list.head, null);
            PrintList(list);
            Console.WriteLine("\nСодержит?\n");
            Console.Write("5: ");
            Console.WriteLine(list.Contains(5, list.head));
            Console.Write("3: ");
            Console.WriteLine(list.Contains(3, list.head));
            Console.Write("20: ");
            Console.WriteLine(list.Contains(20, list.head));
            Console.Write("1: ");
            Console.WriteLine(list.Contains(1, list.head));
            Console.ReadKey();
        }

        //печать коллекции
        static void PrintList(MyLinkedList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
