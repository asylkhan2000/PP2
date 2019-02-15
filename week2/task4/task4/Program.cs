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
            string s = Console.ReadLine();
            writer.Write(s);
            writer.Close();
            File.Copy(@"C:\Users\FORA-TRADE\Desktop\PP2\week2\task4\first.txt", @"C:\Users\FORA-TRADE\Desktop\PP2\week2\task4\second.txt");
            File.Delete(@"C:\Users\FORA-TRADE\Desktop\PP2\week2\task4\first.txt");
        }
    }
}
