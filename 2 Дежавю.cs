using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static string input(string message = "")
        {
            if(message!="") WriteLine(message);
            return ReadLine();
        }
        static float pfloat(string str)
        {
            float.TryParse(str, out float n);
            return n;
        }
        static void print(params object[] strs)
        {
            int i = 0;
            foreach (object str in strs)
            {
                string end = (i == strs.Length - 1) ? "" : " ";
                Write("{0}{1}", str, end);
                i++;
            }
            WriteLine();
        }
        static void Main(string[] args)
        {
            float a = pfloat(input("Введите a"));
            float b = pfloat(input("Введите b"));
            
            print("Дано");
            print("a =", a, ", b =", b);
            print("Сумма равна");
            print(a + b);
            input();
        }
    }
}
