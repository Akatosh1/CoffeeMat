using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes.Commands
{
    internal class ChangeLocalesCommand : ICommand
    {
        public string Execute(string[] args)
        {
            if (args != null) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            if (Locales.CurrentLocale == "rus") Locales.CurrentLocale = "eng";
            else Locales.CurrentLocale = "rus";
            return Locales.phrases[Locales.CurrentLocale]["ChangeLocales"];         
        }

        public string GetDescription()
        {
            return Locales.phrases[Locales.CurrentLocale]["LocalesCommandDescription"];
        }
    }
}
