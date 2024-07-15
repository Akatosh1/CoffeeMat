using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes
{
    public static class Locales
    {
        public static string CurrentLocale = "eng";
        public static Dictionary<string, Dictionary<string, string>> phrases = new Dictionary<string, Dictionary<string, string>>();

        public static Dictionary<string,string> CreateRusLocales()
        {
            var rusDictionary = new Dictionary<string, string>();
            rusDictionary.Add("IncorrectRequest", "Неправильный запрос");
            rusDictionary.Add("ChangeLocales", "Локализация изменена на русскую");
            rusDictionary.Add("Balance",  "Баланс {0} рублей");
            rusDictionary.Add("Order", "Ваш заказ: {0}");
            rusDictionary.Add("ExtraSugar", "плюс {0} сахар");
            rusDictionary.Add("ExtraMilk", "плюс {0} молоко");
            rusDictionary.Add("Price", " цена:");
            rusDictionary.Add("Rubles", "рублей");
            rusDictionary.Add("NotEnoughMoney", "Не хватает {0} {1}");
            rusDictionary.Add("OrderNotFormed", "Заказ не сформирован");
            rusDictionary.Add("ResourceAmount", "Количество {0} {1} у.е");
            rusDictionary.Add("OutOfResource", "Ресурс {0} закончился");
            rusDictionary.Add("NoMoney", "Такая валюта не принимается");
            rusDictionary.Add("GiveChange", "Ваша сдача:");

            rusDictionary.Add("LocalesCommandDescription", "Меняет текущую локализацию");
            rusDictionary.Add("AddInCoffeeCommandDescription", "Добавляет добавку к кофе");
            rusDictionary.Add("AddMoneyCommandDescription", "Вносит деньги в автомат");
            rusDictionary.Add("ChooseCoffeeCommandDescription", "Делает выбор кофе в заказе");
            rusDictionary.Add("CoffeeListCommandDescription", "Показывает список доступных видов кофе");
            rusDictionary.Add("OrderListCommandDescription", "Показывает список заказов");
            rusDictionary.Add("ExecuteCommandDescription", "Создает заказ");
            rusDictionary.Add("FillResourceCommandDescription", "Пополняет один из ресурсов на введённое количество у.е");
            rusDictionary.Add("HelpCommandDescription", "Показывает список доступных команд");
            rusDictionary.Add("ResourceAmountOnCommandDescription", "Показывает кол-во выбранного ресурса");
            return rusDictionary;
        }

        public static Dictionary<string, string> CreateEngLocales()
        {
            var engDictionary = new Dictionary<string, string>();
            engDictionary.Add("IncorrectRequest", "Incorrect Request");
            engDictionary.Add("ChangeLocales", "Change locales on english");
            engDictionary.Add("Balance", "Balance {0} rubles");
            engDictionary.Add("Order", "Your order: {0}");
            engDictionary.Add("ExtraSugar", "plus {0} sugar");
            engDictionary.Add("ExtraMilk", "plus {0} milk");
            engDictionary.Add("Price", " price:");
            engDictionary.Add("Rubles", "rubles");
            engDictionary.Add("NotEnoughMoney", "{0} {1} are missing");
            engDictionary.Add("OrderNotFormed", "Order not formed");
            engDictionary.Add("ResourceAmount", "Amount of {0} {1} units");
            engDictionary.Add("OutOfResource", "Out of resource {0}");
            engDictionary.Add("NoMoney", "Such currency is not accepted");
            engDictionary.Add("GiveChange", "Your Change:");


            engDictionary.Add("LocalesCommandDescription", "Change current locales");
            engDictionary.Add("AddInCoffeeCommandDescription", "Add extras to coffee");
            engDictionary.Add("AddMoneyCommandDescription", "Increase amount of money");
            engDictionary.Add("ChooseCoffeeCommandDescription", "Make choice of coffee in order");
            engDictionary.Add("CoffeeListCommandDescription", "Show all coffee choices");
            engDictionary.Add("OrderListCommandDescription", "Show purchases list");
            engDictionary.Add("ExecuteCommandDescription", "Create order");
            engDictionary.Add("FillResourceCommandDescription", "Fill resource with the entered amount of units");
            engDictionary.Add("HelpCommandDescription", "Show list of available commands");
            engDictionary.Add("ResourceAmountOnCommandDescription", "Show the amount of chosen resource");
            return engDictionary;
        }

        public static void CreateLocales()
        {
            phrases.Add("rus", CreateRusLocales());
            phrases.Add("eng", CreateEngLocales());
        }
    }
}
