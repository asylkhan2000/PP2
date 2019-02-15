using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\FORA-TRADE\Desktop\PP2\week2\task4\first.txt");
            string s = Console.ReadLine();//переменную заполняем текстом через консоль
            writer.Write(s);//заполняем файл текстом
            writer.Close();
            File.Copy(@"C:\Users\FORA-TRADE\Desktop\PP2\week2\task4\first.txt", @"C:\Users\FORA-TRADE\Desktop\PP2\week2\task4\second.txt");//копируем файл в другой файл
            File.Delete(@"C:\Users\FORA-TRADE\Desktop\PP2\week2\task4\first.txt");//удаляем первый файл
        }
    }
}
