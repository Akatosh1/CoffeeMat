using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return "Показывает список доступных команд";
        }
    }
}
