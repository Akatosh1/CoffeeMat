using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMat.Classes.Commands
{
    internal class CoffeeListCommand : ICommand
    {
        public string Execute(string[] args)
        {
            var databaseDao = new DataBaseDao();
            var stringBuilder = new StringBuilder();
            var coffeeList = databaseDao.GetSqlTableList("coffee");

            foreach(Coffee coffee in coffeeList)
            {
                stringBuilder.Append(coffee.Name);
                stringBuilder.Append("  цена:");
                stringBuilder.AppendLine(coffee.Amount.ToString());
            }
            return stringBuilder.ToString();
        }

        public string GetDescription()
        {
            return "Показывает список доступных видов кофе";
        }
    }
}
