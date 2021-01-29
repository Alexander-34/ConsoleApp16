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
        IRunnable withX = new WithX();
        if (withX is IRunnable)
        {
            withX.Run();
        }
        ReadKey();
        }
    }
}
