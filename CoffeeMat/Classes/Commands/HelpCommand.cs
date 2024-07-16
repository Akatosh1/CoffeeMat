using System.Linq;
using System.Text;

namespace CoffeeMat.Classes.Commands
{
    internal class HelpCommand : ICommand
    {
        public string Execute(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var commandNames = CoffeeConsoleManager.commands.Keys.ToList();
            var commandItems = CoffeeConsoleManager.commands.Values.ToList();
            for (int i = 0; i < commandItems.Count; i++)
            {
                stringBuilder.Append(commandNames[i]);
                stringBuilder.Append(", ");
                stringBuilder.AppendLine(commandItems[i].GetDescription());
            }
            return stringBuilder.ToString();
        }

        public string GetDescription()
        {
            return Locales.GetLocales("HelpCommandDescription");
        }
    }
}
