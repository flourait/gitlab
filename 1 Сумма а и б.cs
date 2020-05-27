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
        static void Main(string[] args)
        {
            WriteLine("Введите a");
            string StringA = ReadLine();
            WriteLine("Введите b");
            string StringB = ReadLine();
            float.TryParse(StringA, out float a);
            float.TryParse(StringA, out float b);
            WriteLine("Дано");
            WriteLine("a={0}\n b={1}", a, b);
            WriteLine("Сумма равна");
            WriteLine(a + b);
            ReadLine();
        }
    }
}
