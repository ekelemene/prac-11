using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 6.Подсчет количества вхождений определенного числа в массив.
            int[] omas = { 3, 7, 1, 9, 5, 3, 6, 3, 3 };
            Console.Write("Введите число для подсчета: ");
            int i = int.Parse(Console.ReadLine());
            int count = Array.FindAll(omas, x => x == i).Length;
            Console.WriteLine($"Число {i} встречается {count} раза в массиве.");
            Console.ReadLine();

            //int[] omas = { 3, 7, 1, 9, 5, 3, 6, 3 };
            //int count = 0;
            //foreach (int x in omas)
            //{
            //    if (x == 3)
            //    { count++; }
            //}
            //Console.WriteLine(count);
            //Console.ReadLine();

            //int[] omas = { 3, 7, 1, 9, 5, 3, 6, 3, };
            //int count = omas.Count(x=>x==3);
            //Console.WriteLine(count);
            //Console.ReadLine();





        }
    }
}
