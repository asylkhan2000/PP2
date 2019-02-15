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
        static bool Prime(int a)
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
            StreamReader input = new StreamReader(@"C:\Users\FORA-TRADE\Desktop\PP2\week2\task2\input.txt");
            StreamWriter output = new StreamWriter(@"C:\Users\FORA-TRADE\Desktop\PP2\week2\task2\output.txt");
            string s = input.ReadToEnd();
            string[] arr = s.Split(' ');
            foreach (string n in arr)
            {
                if (Prime(int.Parse(n)))
                {
                    output.Write(n + " ");
                }
            }
            input.Close();
            output.Close();
        }
    }
}
