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
            var coffee = dataBaseDAO.GetCoffeeFromSql(args[0]);


            if (!dataBaseDAO.CheckResource("milk", -coffee.MilkAmount)) 
                return Locales.phrases[Locales.CurrentLocale]["NotEnoughResource"];
            if (!dataBaseDAO.CheckResource("water", -coffee.WaterAmount))
                return Locales.phrases[Locales.CurrentLocale]["NotEnoughResource"];
            if (!dataBaseDAO.CheckResource("plasticCups", -1))
                return Locales.phrases[Locales.CurrentLocale]["NotEnoughResource"];
            if (!dataBaseDAO.CheckResource("blendedCoffee", -coffee.CoffeeAmount))
                return Locales.phrases[Locales.CurrentLocale]["NotEnoughResource"];

            var difference = Order.CoffeeMachineBalance - coffee.Amount;
            if (difference >= 0)
            {
                Order.Coffee = coffee;
                return Order.CreateOrderString();
            }
            else return string.Format(
                Locales.phrases[Locales.CurrentLocale]["NotEnoughMoney"],
                -difference,
                Locales.phrases[Locales.CurrentLocale]["Rubles"]);
        }

        public string GetDescription()
        {
            return Locales.phrases[Locales.CurrentLocale]["ChooseCoffeeCommandDescription"];
        }
    }
}
