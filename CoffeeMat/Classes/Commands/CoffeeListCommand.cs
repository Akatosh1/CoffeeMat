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
                stringBuilder.Append(Locales.phrases[Locales.CurrentLocale]["Price"]);
                stringBuilder.Append(coffee.Amount.ToString());
                stringBuilder.Append(" ");
                stringBuilder.AppendLine(Locales.phrases[Locales.CurrentLocale]["Rubles"]);
            }
            return stringBuilder.ToString();
        }

        public string GetDescription()
        {
            return Locales.phrases[Locales.CurrentLocale]["CoffeeListCommandDescription"];
        }
    }
}
