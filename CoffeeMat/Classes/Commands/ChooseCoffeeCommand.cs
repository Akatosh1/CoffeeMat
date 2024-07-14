using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes.Commands
{
    internal class ChooseCoffeeCommand : ICommand
    {
        public string Execute(string[] args)
        {
            if (args == null) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            var dataBaseDAO = new DataBaseDao();
            Order.Coffee = dataBaseDAO.GetCoffeeFromSql(args[0]);
            return Order.CreateOrderString();
        }

        public string GetDescription()
        {
            return Locales.phrases[Locales.CurrentLocale]["ChooseCoffeeCommandDescription"];
        }
    }
}
