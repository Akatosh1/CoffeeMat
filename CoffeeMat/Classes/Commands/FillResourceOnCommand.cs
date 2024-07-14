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
            if (!int.TryParse(args[1], out int amount)) return "Некорректный запрос";
            var dataBaseDao = new DataBaseDao();
            return dataBaseDao.UpdateOnResource(args[0], amount);
        }

        public string GetDescription()
        {
            return "Пополняет один из ресурсов на введённое количество у.е";
        }
    }
}
