using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 10. Удаление всех четных элементов из массива. в новой массиве сложить элементыю
            int[] omas = { 1, 2, 3, 4, 5, 2, 2, 6, 7, 2 };
            omas = omas.Where(x => x % 2 != 0).ToArray();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            int sum = omas.Sum();
            Console.WriteLine(sum);

            Console.ReadLine();



        }
    }
}
