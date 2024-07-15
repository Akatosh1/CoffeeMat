using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes.Commands
{
    internal class ExecuteOrderCommand : ICommand
    {
        public string Execute(string[] args)
        {
            if (Order.Coffee == null) return Locales.phrases[Locales.CurrentLocale]["OrderNotFormed"];
            var dataBaseDao = new DataBaseDao();

            var resources = new Dictionary<string, int>() {
                { "milk", -Order.Coffee.MilkAmount - Order.ExtraMilkAmount },
                { "water", -Order.Coffee.WaterAmount },
                { "plasticCups", -1 },
                { "blendedCoffee", -Order.Coffee.CoffeeAmount },
                { "sugar",  - Order.ExtraSugarAmount}
            };
            foreach (var resource in resources.Keys)
            {
                var checkString = dataBaseDao.CheckResource(resource, resources[resource]);
                if (checkString.Length != 0) return checkString;
            }

            var difference = Order.CoffeeMachineBalance - Order.Coffee.Amount;
            if (difference >= 0) return dataBaseDao.UpdateOnOrder();
            else return string.Format(
                Locales.phrases[Locales.CurrentLocale]["NotEnoughMoney"], 
                -difference,
                Locales.phrases[Locales.CurrentLocale]["Rubles"]);
        }

        public string GetDescription()
        {
            return Locales.phrases[Locales.CurrentLocale]["ExecuteCommandDescription"];
        }
    }
}
