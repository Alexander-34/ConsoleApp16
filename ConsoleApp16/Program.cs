using System;

using ConsoleApp16;
using static System.Console;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp16.Command;

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
            string cmd;
            bool IsStop = false;
            ICommand[] commands = {
                new Output1Command(),
                new OutputHiCommand(),
                new ExitCommand(),
                new InputErrorCommand(),
            };
            do
            {
                WriteLine("Menu:");
                foreach (object command in commands)
                {
                    if (command is IPrintable)
                    {
                        WriteLine(command);
                    }
                }
                Write("Введите номер действия: ");
                cmd = ReadLine();
                foreach (ICommand command in commands)
                {
                    if (command.CanExecute(cmd))
                    {
                        string output = command.Execute(ref IsStop);
                        WriteLine(output);
                        break;
                    }
                }
            } while (!IsStop);
            /* мое - коммент
            string cmd;
                bool IsStop = false;
                ICommand[] commands =
                    {
                    new Output1Command(),
                    new OutputHiCommand(),
                    new ExitCommand(),
                    new InputEncodingErrorCommand(),
                };
            do
            {
               WriteLine("Menu:");
            WriteLine("1. Вывести '1'");
            WriteLine("2. Вывести 'Привет'");
            WriteLine("3. Выход");
            Write("Введите номер действия: ");
            cmd = ReadLine();
            foreach (ICommand command in commands)
                {
                    if (command.CanExecute(cmd))
                    {
                        string output = command.Execute(ref IsStop);
                        WriteLine(output);
                    }
                }
                // ------------------------
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
            */
            ReadKey();
        }
    }
}
