using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes.Commands
{
    internal class OrderListCommand : ICommand
    {
        public string Execute(string[] args)
        {
            var databaseDao = new DataBaseDao();
            var stringBuilder = new StringBuilder();
            var purchaseList = databaseDao.GetSqlTableList("purchase");

            foreach (Purchase purchase in purchaseList)
            {
                stringBuilder.Append(purchase.Name);
                stringBuilder.Append(Locales.phrases[Locales.CurrentLocale]["Price"]);
                stringBuilder.Append(purchase.Amount.ToString());
                stringBuilder.Append(" ");
                stringBuilder.AppendLine(Locales.phrases[Locales.CurrentLocale]["Rubles"]);
            }
            return stringBuilder.ToString();
        }

        public string GetDescription()
        {
            return Locales.phrases[Locales.CurrentLocale]["OrderListCommandDescription"];
        }
    }
}
