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
            var rusDictionary = new Dictionary<string, string>
            {
                { "IncorrectRequest", "Неправильный запрос" },
                { "ChangeLocales", "Локализация изменена на русскую" },
                { "Balance", "Баланс {0} рублей" },
                { "Order", "Ваш заказ: {0}" },
                { "ExtraSugar", "плюс {0} сахар" },
                { "ExtraMilk", "плюс {0} молоко" },
                { "Price", " цена:" },
                { "Rubles", "рублей" },
                { "NotEnoughMoney", "Не хватает {0} {1}" },
                { "OrderNotFormed", "Заказ не сформирован" },
                { "ResourceAmount", "Количество {0} {1} у.е" },
                { "OutOfResource", "Ресурс {0} закончился" },
                { "NoMoney", "Такая валюта не принимается" },
                { "GiveChange", "Ваша сдача:" },
                { "NotEnoughResource", "Не хватает ресурса {0}" },

                { "water", "Вода" },
                { "milk", "молоко" },
                { "sugar", "Сахар" },
                { "plasticCups", "Пластиковые стаканчики" },
                { "blendedCoffee", "Молотый кофе" },

                { "LocalesCommandDescription", "Меняет текущую локализацию" },
                { "AddInCoffeeCommandDescription", "Добавляет добавку к кофе" },
                { "AddMoneyCommandDescription", "Вносит деньги в автомат" },
                { "ChooseCoffeeCommandDescription", "Делает выбор кофе в заказе" },
                { "CoffeeListCommandDescription", "Показывает список доступных видов кофе" },
                { "OrderListCommandDescription", "Показывает список заказов" },
                { "ExecuteCommandDescription", "Создает заказ" },
                { "FillResourceCommandDescription", "Пополняет один из ресурсов на введённое количество у.е" },
                { "HelpCommandDescription", "Показывает список доступных команд" },
                { "ResourceAmountOnCommandDescription", "Показывает кол-во выбранного ресурса" }
            };
            return rusDictionary;
        }

        public static Dictionary<string, string> CreateEngLocales()
        {
            var engDictionary = new Dictionary<string, string>
            {
                { "IncorrectRequest", "Incorrect Request" },
                { "ChangeLocales", "Change locales on english" },
                { "Balance", "Balance {0} rubles" },
                { "Order", "Your order: {0}" },
                { "ExtraSugar", "plus {0} sugar" },
                { "ExtraMilk", "plus {0} milk" },
                { "Price", " price:" },
                { "Rubles", "rubles" },
                { "NotEnoughMoney", "{0} {1} are missing" },
                { "OrderNotFormed", "Order not formed" },
                { "ResourceAmount", "Amount of {0} {1} units" },
                { "OutOfResource", "Out of resource {0}" },
                { "NoMoney", "Such currency is not accepted" },
                { "GiveChange", "Your Change:" },
                { "NotEnoughResource", "Not Enough {0}" },

                { "water", "Water" },
                { "milk", "Milk" },
                { "sugar", "Sugar" },
                { "plasticCups", "Plastic Cups" },
                { "blendedCoffee", "Blended Coffee" },

                { "LocalesCommandDescription", "Change current locales" },
                { "AddInCoffeeCommandDescription", "Add extras to coffee" },
                { "AddMoneyCommandDescription", "Increase amount of money" },
                { "ChooseCoffeeCommandDescription", "Make choice of coffee in order" },
                { "CoffeeListCommandDescription", "Show all coffee choices" },
                { "OrderListCommandDescription", "Show purchases list" },
                { "ExecuteCommandDescription", "Create order" },
                { "FillResourceCommandDescription", "Fill resource with the entered amount of units" },
                { "HelpCommandDescription", "Show list of available commands" },
                { "ResourceAmountOnCommandDescription", "Show the amount of chosen resource" }
            };
            return engDictionary;
        }

        public static void CreateLocales()
        {
            phrases.Add("rus", CreateRusLocales());
            phrases.Add("eng", CreateEngLocales());
        }
    }
}
