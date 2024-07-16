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
            if (args == null) return Locales.GetLocales("IncorrectRequest");
            var dataBaseDao = new DataBaseDao();
            return (args != null) ? dataBaseDao.FindResourceAmount(args[0]) : Locales.GetLocales("IncorrectRequest");
        }

        public string GetDescription()
        {
            return Locales.GetLocales("ResourceAmountOnCommandDescription");
        }
    }
}
