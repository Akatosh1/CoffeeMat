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
