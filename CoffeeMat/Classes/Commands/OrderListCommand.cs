using System.Text;

namespace CoffeeMat.Classes.Commands
{
    public class OrderListCommand : ICommand
    {
        public string Execute(string[] args)
        {
            var databaseDao = new DataBaseDao();
            var stringBuilder = new StringBuilder();
            var purchaseList = databaseDao.GetSqlTableList("purchase");

            foreach (Purchase purchase in purchaseList)
            {
                stringBuilder.Append(purchase.Name);
                stringBuilder.Append(Locales.GetLocales("Price"));
                stringBuilder.Append(purchase.Amount.ToString());
                stringBuilder.Append(" ");
                stringBuilder.AppendLine(Locales.GetLocales("Rubles"));
            }
            return stringBuilder.ToString();
        }

        public string GetDescription()
        {
            return Locales.GetLocales("OrderListCommandDescription");
        }
    }
}
