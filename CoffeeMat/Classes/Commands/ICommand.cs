using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes.Commands
{
    internal interface ICommand
    {
        string GetDescription();

        string Execute(string[] args);
    }
}
