using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleApp1
{
    class SummMachine
    {
        public float a, b;
        float summ;
        private string message = "Введите {0}";
        public void input(string varName)
        {
            WriteLine(this.message, varName);
            string str = ReadLine();
            float.TryParse(str, out float n);
            switch (varName)
            {
                case "a":
                    this.a = n;
                    break;
                case "b":
                    this.b = n;
                    break;
                default:
                    WriteLine("Переменная указана не верно");
                    break;
            }
            /*Равносильно
            if (varName == "a") {
                this.a = n;
            } else if (varName == "b")
            {
                this.b = n;
            } else
            {
                WriteLine("Переменная указана не верно");
            }*/
        }

        public void compute()
        {
            this.summ = this.a + this.b;
        }
        public void info()
        {
            this.thereIs();
            this.answer();
        }
        void thereIs()
        {
            WriteLine("Дано");
            WriteLine("a = {0}, b = {1}", this.a, this.b);
        }
        void answer()
        {
            WriteLine("Сумма равна");
            WriteLine(this.summ);
            ReadKey();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            SummMachine s = new SummMachine();
            s.input("a");
            s.input("b");
            s.compute();
            s.info();
        }
    }
}
