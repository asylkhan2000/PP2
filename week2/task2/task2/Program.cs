using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static bool Prime(int a)//создаем функцию, которая принимает целое число и возвращает true, если число простое или false, если нет
        {
            if (a == 1)
            {
                return false;
            }
            for(int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader(@"C:\Users\FORA-TRADE\Desktop\PP2\week2\task2\input.txt");//считываем текст из файла input.txt
            StreamWriter output = new StreamWriter(@"C:\Users\FORA-TRADE\Desktop\PP2\week2\task2\output.txt");
            string s = input.ReadToEnd();//сохраняем весь текст из файла в переменную s
            string[] arr = s.Split(' ');//сохраняем в массив строки, отделенные пробелом в строке s
            foreach (string n in arr)//пробегаемся по всем элементам массива
            {
                if (Prime(int.Parse(n)))//обращаемся к функции Prime, переводя элемент массива из строки в целое число
                {
                    output.Write(n + " ");//вывод простых чисел в файл output через пробел
                }
            }
            input.Close();
            output.Close();
        }
    }
}
