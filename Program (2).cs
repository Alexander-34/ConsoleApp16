using ConsoleApp3.Command;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
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
                    if (command is IPrintable) {
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
            ReadKey();
        }
    }
}
