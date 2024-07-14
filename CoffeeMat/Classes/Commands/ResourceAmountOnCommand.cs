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
            return (args != null) ? dataBaseDao.FindResourceAmount(args[0]) : "Не введено название ресурса";
        }

        public string GetDescription()
        {
            return "Показывает кол-во выбранного ресурса";
        }
    }
}
