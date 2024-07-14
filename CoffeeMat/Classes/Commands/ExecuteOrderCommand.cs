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
            if (Order.Coffee == null) return "Заказ не сформирован";
            var dataBaseDao = new DataBaseDao();
            var difference = Order.CoffeeMachineBalance - Order.Coffee.Amount;
            if (difference >= 0) return dataBaseDao.UpdateOnOrder();
            else return $"Не хватает {difference} рублей";
        }

        public string GetDescription()
        {
            return "Делает заказ";
        }
    }
}
