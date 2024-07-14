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
            if (args == null) return "Не введено название кофе";
            var dataBaseDAO = new DataBaseDao();
            Order.Coffee = dataBaseDAO.GetCoffeeFromSql(args[0]);
            return $"Ваш заказ {args[0]}";
        }

        public string GetDescription()
        {
            return "Делает выбор кофе в заказе";
        }
    }
}
