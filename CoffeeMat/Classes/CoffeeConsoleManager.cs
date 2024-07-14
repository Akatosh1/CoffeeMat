using CoffeeMat.Classes.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeMat.Classes
{
    internal class CoffeeConsoleManager
    {
        public static Dictionary<String, ICommand> commands = new Dictionary<String, ICommand>();

        public void InitCommands()
        {
            commands.Add("Help", new HelpCommand());
            commands.Add("Помощь", new HelpCommand());
            commands.Add("ChangeLocales", new ChangeLocalesCommand());
            commands.Add("ПоменятьЛокализацию", new ChangeLocalesCommand());
            commands.Add("CoffeeList", new CoffeeListCommand());
            commands.Add("СписокКофе", new CoffeeListCommand());
            commands.Add("AddInCoffee", new AddInCoffeeCommand());
            commands.Add("ДобавитьВКофе", new AddInCoffeeCommand());
            commands.Add("AddMoney", new AddMoneyCommand());
            commands.Add("ПовыситьБаланс", new AddMoneyCommand());
            commands.Add("ChooseCoffee", new ChooseCoffeeCommand());
            commands.Add("ВыбратьКофе", new ChooseCoffeeCommand());
            commands.Add("ExecuteOrder", new ExecuteOrderCommand());
            commands.Add("ВыполнитьЗаказ", new ExecuteOrderCommand());
            commands.Add("FillResourceOn", new FillResourceOnCommand());
            commands.Add("ПополнитьРесурс", new FillResourceOnCommand());
            commands.Add("ResourceAmount", new ResourceAmountOnCommand());
            commands.Add("КоличествоРесурсов", new ResourceAmountOnCommand());
        }
        public string GetCommand(string command) 
        {
            string[] parameters = command.Split(' ');
            var commandName = parameters[0];
            var commandArgs = parameters.Length > 1 ? parameters.Skip(1).ToArray() : null;
            try{return commands[commandName].Execute(commandArgs);}
            catch(KeyNotFoundException){ return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"]; }
        }
    }
}
