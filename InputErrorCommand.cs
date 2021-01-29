using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Command
{
    class InputErrorCommand : ICommand
    {
        public bool CanExecute(string cmd)
        {
            return true;
        }

        public string Execute(ref bool IsStop)
        {
            return "Ошибка ввода. Попробуйте ещё раз.";
        }
    }
}
