using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes.Commands
{
    internal class AddMoneyCommand : ICommand
    {
        public string Execute(string[] args)
        {         
            if (int.TryParse(args[0],out int arg))
            {
                Order.CoffeeMachineBalance += arg;

                return string.Format(Locales.phrases[Locales.CurrentLocale]["Balance"], Order.CoffeeMachineBalance);
            }
            else
            {
                return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            }
        }

        public string GetDescription()
        {
            return Locales.phrases[Locales.CurrentLocale]["AddMoneyCommandDescription"];
        }
    }
}
