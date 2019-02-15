using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static bool Polyndrome(string s)//создаем функцию, которая возвращает true, если слово полиндром или false, если слово не полиндром
        {
            for(int i = 0; i <= s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader a = new StreamReader(@"C:\Users\FORA-TRADE\Desktop\PP2\week2\task1\task1.txt");//считываем текст из файла
            string s = a.ReadToEnd();//сохраняем весь текст из файла 
            if (Polyndrome(s))//обращаемся к функции Polyndrome
            {
                Console.WriteLine("Yes");//если слово полиндром, выводим Yes
            }
            else
            {
                Console.WriteLine("No");//иначе выводим No
            }
        }
    }
}
