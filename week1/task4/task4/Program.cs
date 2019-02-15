using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//создаем и вводим переменную n - размер двумерного массива
            int[,] arr = new int[n, n];//создаем двумерный массив
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("[*]");//заполняем массив [*] 
                    }
                }
                Console.WriteLine("\n");//после каждой строки перенос на новую
            }
        }
    }
}
