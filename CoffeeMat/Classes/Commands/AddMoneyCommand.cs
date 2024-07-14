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
                return $"Баланс '{Order.CoffeeMachineBalance}'";
            }
            else
            {
                return "Некорректная команда";
            }
        }

        public string GetDescription()
        {
            return "Вносит деньги в автомат";
        }
    }
}
