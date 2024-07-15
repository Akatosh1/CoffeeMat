using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes.Commands
{
    internal class AddInCoffeeCommand : ICommand
    {

        public string Execute(string[] args)
        {
            if (args == null) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            if (args.Length != 2) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            if (!int.TryParse(args[1], out int amount)) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];

            var dataBaseDao = new DataBaseDao();
            if (!dataBaseDao.CheckResource(args[0], -1))
                return string.Format(Locales.phrases[Locales.CurrentLocale]["NotEnoughResource"],
                    Locales.phrases[Locales.CurrentLocale][args[0]]);


            return dataBaseDao.UpdateResourceOnCoffee(args[0], amount);
        }

        public string GetDescription()
        {
            return Locales.phrases[Locales.CurrentLocale]["AddInCoffeeCommandDescription"];
        }
    }
}
