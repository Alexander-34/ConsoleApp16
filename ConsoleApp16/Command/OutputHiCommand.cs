using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Command
{
    class OutputHiCommand : ICommand, IPrintable
    {
        public bool CanExecute(string cmd)
        {
            return cmd == "2";
        }
        public string Execute (ref bool IsStop)
        {
            
            return "Привет";
        }
        public override string ToString()
        {
            return "2. Вывести 'Привет'";
        }
    }
    
    
}
