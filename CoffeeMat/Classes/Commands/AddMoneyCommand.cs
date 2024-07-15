﻿using System;
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
            if (args == null) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            if (int.TryParse(args[0],out int arg))
            {
                if (!Order.ValidMoneyAmounts.Contains(arg)) return Locales.phrases[Locales.CurrentLocale]["NoMoney"];

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
