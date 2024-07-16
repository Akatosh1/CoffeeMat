using System.Text;

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
                stringBuilder.Append(Locales.GetLocales("Price"));
                stringBuilder.Append(coffee.Amount.ToString());
                stringBuilder.Append(" ");
                stringBuilder.AppendLine(Locales.GetLocales("Rubles"));
            }
            return stringBuilder.ToString();
        }

        public string GetDescription()
        {
            return Locales.GetLocales("CoffeeListCommandDescription");
        }
    }
}
