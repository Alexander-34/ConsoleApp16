using System;
using System.Windows.Input;
using static System.Console;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        internal interface IRunnable
        {
            int Run();            
        }
        internal interface IOpenable
        {
            bool Open();            
        }
        class WithX : IRunnable, IOpenable
        {
            public int X { get; }
            public bool Open()
            {
                return true;
            }
            public int Run()
            { 
            return X;
            }
        }

        static void Main(string[] args)
        {
         do {
            string cmd;
            WriteLine("Menu:");
            WriteLine("1. Вывести '1'");
            WriteLine("2. Вывести 'Привет'");
            WriteLine("3. Выход");
            Write("Введите номер действия: ");
            cmd = ReadLine();
            if (cmd == "1")
            {
                WriteLine("1");
            } else if (cmd == "2")
            {
                WriteLine("Привет");
            }
            else if (cmd == "3")
            {
                break;
            }
            else
            {
                WriteLine("Ошибка ввода. Попробуйте еще раз.");
            }
         }  while (true) ;
                ReadKey();
        }
    }
}
