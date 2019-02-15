using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//создаем и вводим переменную n - количество элементов массива
            int[] arr = new int[n];//создаем массив целых чисел
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());//заполняем массив целыми числами
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " " + arr[i] + " ");//выводим каждый элемент массива дважды
            }
        }
    }
}
