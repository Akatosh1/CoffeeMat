using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes.Commands
{
    internal class FillResourceOnCommand : ICommand
    {
        public string Execute(string[] args)
        {
            if (args == null) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            if (!int.TryParse(args[1], out int amount)) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            var dataBaseDao = new DataBaseDao();

            var checkString = dataBaseDao.CheckResource(args[0], amount);
            if (checkString.Length != 0) return checkString;
                

            return dataBaseDao.UpdateResourceOnStorage(args[0], amount);
        }

        public string GetDescription()
        {
            return Locales.phrases[Locales.CurrentLocale]["FillResourceCommandDescription"];
        }
    }
}
