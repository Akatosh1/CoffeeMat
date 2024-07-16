using System.Collections.Generic;

namespace CoffeeMat.Classes
{
    public static class Locales
    {
        public static string CurrentLocale = "eng";
        public static Dictionary<string, Dictionary<string, string>> phrases = new Dictionary<string, Dictionary<string, string>>();

        public static string GetLocales(string value)
        {
            return Locales.phrases[Locales.CurrentLocale][value];
        }
        public static Dictionary<string,string> CreateRusLocales()
        {
            var rusDictionary = new Dictionary<string, string>
            {
                { "IncorrectRequest", "Неправильный запрос" },
                { "ChangeLocales", "Локализация изменена на русскую" },
                { "Balance", "Баланс {0} рублей" },
                { "Order", "Ваш заказ: {0}" },
                { "ExtraSugar", "Плюс {0} сахар" },
                { "ExtraMilk", "Плюс {0} молоко" },
                { "Price", "Цена" },
                { "Picture", "Изображение" },
                { "Rubles", "Рублей" },
                { "NotEnoughMoney", "Не хватает {0} {1}" },
                { "OrderNotFormed", "Заказ не сформирован" },
                { "ResourceAmount", "Количество {0} {1} у.е" },
                { "OutOfResource", "Ресурс {0} закончился" },
                { "NoMoney", "Такая валюта не принимается" },
                { "GiveChange", "Ваша сдача:" },
                { "NotEnoughResource", "Не хватает ресурса {0}" },
                { "StorageIsFull", "Хранилище ресурса {0} заполнено" },
                { "AdditionError", "Ошибка с добавлением в базу" },
                { "OutOfSymbolsError", "Название должно быть короче 50 символов"},
                { "Success", "Успешно" },
                { "Add", "Добавить"},
                { "AddPicture", "Добавить изображение"},
                { "Name", "Название" },
                { "Receipt", "Рецепт" },
                { "ExecuteOrder", "Оформить заказ" },
                { "LocalesButton", "Поменять локализацию" },
                { "CoffeeMachineButton", "Запуск кофе машины" },
                { "CoffeeChangeButton", "Редактирование видов кофе" },
                { "ConsoleButton", "Работа с консолью" },
                { "OrderListButton", "Список заказов" },
                { "AddToOrderExtrasQuestion", "Желаете добавить что-то к заказу?" },

                { "water", "Вода" },
                { "milk", "молоко" },
                { "sugar", "Сахар" },
                { "plasticCups", "Пластиковые стаканчики" },
                { "blendedCoffee", "Кофе" },

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
                { "ExtraSugar", "Plus {0} sugar" },
                { "ExtraMilk", "Plus {0} milk" },
                { "Price", "Price" },
                { "Picture", "Picture" },
                { "Rubles", "Rubles" },
                { "NotEnoughMoney", "{0} {1} are missing" },
                { "OrderNotFormed", "Order not formed" },
                { "ResourceAmount", "Amount of {0} {1} units" },
                { "OutOfResource", "Out of resource {0}" },
                { "NoMoney", "Such currency is not accepted" },
                { "GiveChange", "Your Change:" },
                { "NotEnoughResource", "Not Enough {0}" },
                { "StorageIsFull", "Storage of {0} is full" },
                { "AdditionError", "Error with addition to base" },
                { "OutOfSymbolsError", "Name should be less than 50 symbols"},
                { "Success", "Success" },
                { "Add", "Add"},
                { "AddPicture", "AddPicture"},
                { "Name", "Name" },
                { "Receipt", "Receipt" },
                { "ExecuteOrder", "Execute order" },
                { "LocalesButton", "Change locales" },
                { "CoffeeMachineButton", "Coffee machine start" },
                { "CoffeeChangeButton", "Coffee change manager" },
                { "ConsoleButton", "Console" },
                { "OrderListButton", "Order list" },
                { "AddToOrderExtrasQuestion", "Do you want some adds to coffee?" },

                { "water", "Water" },
                { "milk", "Milk" },
                { "sugar", "Sugar" },
                { "plasticCups", "Cups" },
                { "blendedCoffee", "Coffee" },

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
