using System.Collections.Generic;

namespace CoffeeMat.Classes.Commands
{
    internal class ChooseCoffeeCommand : ICommand
    {
        public string Execute(string[] args)
        {
            if (args == null) return Locales.GetLocales("IncorrectRequest");
            
            var dataBaseDAO = new DataBaseDao();
            var coffee = dataBaseDAO.GetCoffeeFromSql(args[0]);
            if (coffee == null) return Locales.GetLocales("IncorrectRequest");

            var resources = new Dictionary<string, int>() {
                { "milk", -coffee.MilkAmount }, 
                { "water", -coffee.WaterAmount }, 
                { "plasticCups", -1 }, 
                { "blendedCoffee", -coffee.CoffeeAmount } 
            };
            foreach (var resource in resources.Keys) 
            {
                var checkString = dataBaseDAO.CheckResource(resource, resources[resource]);
                if (checkString.Length != 0) return checkString;
            }

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
            return Locales.GetLocales("ChooseCoffeeCommandDescription");
        }
    }
}
