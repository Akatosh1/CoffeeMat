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

            rusDictionary.Add("LocalesCommandDescription", "Меняет текущую локализацию");
            return rusDictionary;
        }

        public static Dictionary<string, string> CreateEngLocales()
        {
            var engDictionary = new Dictionary<string, string>();
            engDictionary.Add("IncorrectRequest", "Incorrect Request");
            engDictionary.Add("ChangeLocales", "Change locales on english");

            engDictionary.Add("LocalesCommandDescription", "Change current localization");
            return engDictionary;
        }

        public static void CreateLocales()
        {
            phrases.Add("rus", CreateRusLocales());
            phrases.Add("eng", CreateEngLocales());
        }
    }
}
