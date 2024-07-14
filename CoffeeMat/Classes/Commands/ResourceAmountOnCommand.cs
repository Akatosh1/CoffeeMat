using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes.Commands
{
    internal class ResourceAmountOnCommand : ICommand
    {
        public string Execute(string[] args)
        {
            var dataBaseDao = new DataBaseDao();
            return (args != null) ? dataBaseDao.FindResourceAmount(args[0]) : Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
        }

        public string GetDescription()
        {
            return Locales.phrases[Locales.CurrentLocale]["ResourceAmountOnCommandDescription"];
        }
    }
}
