using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 7.Поиск элемента по условию.
            string[] People = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
            //string first = Array.Find(People, person => person.Length > 3);
            //Console.WriteLine(first);
            //string last = Array.FindLast(People, person => person.Length > 3);
            //Console.WriteLine(last);
            //string[] all = Array.FindAll(People, person => person.Length == 3);
            //foreach (var x in all)
            //{
            //    Console.WriteLine(x);
            //}
            Array.Sort(People,1,3);
            foreach (var p in People)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();



        }
    }
}
