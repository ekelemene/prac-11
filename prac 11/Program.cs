using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prac_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Определить количество элементов одномерного массива.
            //int[] omas = { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"размер: {omas.Length}");

            //Задача 2.Обнулить заданный диапазон элементов в одномерном массиве.
            //int[] omas = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("массив");
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            //Array.Clear(omas, 2, 2);
            //Console.WriteLine("обнуленный массив");
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}

            //Задача 3.Найти максимальное и минимальное значение в массиве.
            //int[] omas = { -1, 2, -3, 4, -5 };
            //int max = omas.Max();
            //int min = omas.Min();
            //Console.WriteLine($"min = {min}, max = {max}");

            //Задача 4.Сортировка массива по возрастанию.
            //int[] omas = { -1, 2, -3, 4, -5 };
            //Array.Sort(omas);
            //foreach (int i in omas)
            //{
            //    Console.WriteLine(i);
            //}

            //Задача 5.Реверс массива.
            //int[] omas = { -1, 2, -3, 4, -5 };
            //Array.Reverse(omas);
            //foreach (int i in omas)
            //{
            //    Console.WriteLine(i);
            //}

            //Задача 6. Подсчет количества вхождений определенного числа в массив.
            //int[] omas = { 1, 2, 3, 4, 5, 2, 2, 6, 7, 2 };
            //Console.Write("Введите число для подсчета: ");
            //int i = int.Parse(Console.ReadLine());
            //int count = Array.FindAll(omas, x => x == i).Length;
            //Console.WriteLine($"Число {i} встречается {count} раза в массиве.");

            //Задача 7.Поиск элемента по условию.
            //int[] omas = { 1, 5, 8, 11, 20, 25 };
            //int x = 10;
            //int result = -1;
            //foreach (int el in omas)
            //{
            //    if (el > x) 
            //    {
            //        result = el;
            //        break; 
            //    }
            //}
            //Console.WriteLine($"элемент больший x = {result}");

            //Задача 8. Изменение размера массива.
            //int[] omas = { -1, 2, -3, 4, -5 };
            //Array.Resize(ref omas,10);
            //foreach (int el in omas)
            //{
            //    Console.WriteLine(el);
            //}

            //Задача 9.Поиск индекса элемента.
            //int[] array = { 10, 20, 30, 40, 50, 60 };
            //Console.Write("Введите число для поиска индекса: ");
            //int n = int.Parse(Console.ReadLine());
            //int index = Array.FindIndex(array, x => x == n);
            //if (index >= 0)
            //    Console.WriteLine($"Индекс элемента {n}: {index}");
            //else
            //    Console.WriteLine("Элемент не найден.");

            //Задача 10.Удаление всех четных элементов из массива.
            //int[] omas = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] filt = omas.Where(x => x % 2 != 0).ToArray();
            //Console.WriteLine("Массив после удаления четных элементов:");
            //foreach (int i in filt) 
            //{
            //    Console.Write($" {i}");
            //}

            //Задача 11.Сумма всех элементов массива.
            //int[] omas = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int sum = omas.Sum();
            //Console.WriteLine($"сумма всех эл = {sum}");

            //Задача 12.Умножение всех элементов массива на определенное число.
            //int[] omas = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int mult = 3;
            //int[] resul = omas.Select(x => x * mult).ToArray();
            //Console.WriteLine($"умножение на число {mult}");
            //Console.WriteLine(string.Join(" ", resul));

            //Задача 13. Заполните одномерный массив числовыми данными случайным образом из промежутка [ - 50;50].
            //Подсчитайте количество элементов массива, кратных 3 (размерность массива равна 15).
            //int[] omas = new int[15];
            //Random rnd = new Random();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = rnd.Next(-50, 50);
            //}
            //int count = 0;
            //foreach (int i in omas) 
            //{
            //    if(i%3==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Сгенерированный массив:");
            //Console.WriteLine(string.Join(" ", omas));
            //Console.WriteLine($"Количество элементов, кратных 3: {count}");

            //Задача 14. Дан курс рубля России за январь 2023 года. Рассчитать:
            //double[] kv = { 75.50, 74.80, 76.10, 77.00, 75.90, 74.50, 75.20 };
            //double srz = 0;
            //foreach (var value in kv)
            //{
            //    srz += value;
            //}
            //srz /= kv.Length;

            //double maxKv = kv[0];
            //foreach (var value in kv)
            //{
            //    if (value > maxKv)
            //    {
            //        maxKv = value;
            //    }
            //}

            //double minKv = kv[0];
            //foreach (var value in kv)
            //{
            //    if (value < minKv)
            //    {
            //        minKv = value;
            //    }
            //}

            //int maxKvD = 0;
            //for (int i = 0; i < kv.Length; i++)
            //{
            //    if (kv[i] == maxKv)
            //    {
            //        maxKvD = i + 1; 
            //        break;
            //    }
            //}

            //int minKvD = 0;
            //for (int i = 0; i < kv.Length; i++)
            //{
            //    if (kv[i] == minKv)
            //    {
            //        minKvD = i + 1; 
            //        break;
            //    }
            //}
            //Console.WriteLine($" Среднее значение КВ  {srz:F2}");
            //Console.WriteLine($" Максимальное значение КВ  {maxKv:F2}");
            //Console.WriteLine($" Минимальное значение КВ  {minKv:F2}");
            //Console.WriteLine($" День с максимальным значением КВ  {maxKvD} день");
            //Console.WriteLine($" День с минимальным значением КВ  {minKvD} день");
        }
    }
}
