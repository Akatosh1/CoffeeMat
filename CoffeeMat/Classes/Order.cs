using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeMat.Classes;
using CoffeeMat.Classes.Commands;

namespace CoffeeMat
{
    internal static class Order
    {
        public static Coffee Coffee = null;
        public static int CoffeeMachineBalance = 0;
        public static int ExtraMilkAmount = 0;
        public static int ExtraSugarAmount = 0;
        public static HashSet<int> ValidMoneyAmounts = new HashSet<int>();

        public static void IncreaseBalance(int amount)
        {
            if (ValidMoneyAmounts.Contains(amount)) CoffeeMachineBalance += amount; 
        }

        public static string CreateOrderString()
        {
            return string.Format("{0} {1} {2}",
                string.Format(Locales.phrases[Locales.CurrentLocale]["Order"], Coffee.Name), 
                ExtraSugarAmount > 0 ? 
                string.Format(Locales.phrases[Locales.CurrentLocale]["ExtraSugar"], ExtraSugarAmount) : "",
                ExtraMilkAmount > 0 ? 
                string.Format(Locales.phrases[Locales.CurrentLocale]["ExtraMilk"], ExtraMilkAmount) : "");
        }

        public static void Clear()
        {
            CoffeeMachineBalance = CoffeeMachineBalance - Coffee.Amount;
            var command = new FillResourceOnCommand();
            command.Execute(new string[] { "sugar", (-ExtraSugarAmount).ToString() });
            command.Execute(new string[] { "blendedCoffee", (-Coffee.CoffeeAmount).ToString() });
            command.Execute(new string[] { "plasticCups", (-1).ToString() });
            command.Execute(new string[] { "milk", (-ExtraMilkAmount-Coffee.MilkAmount).ToString() });
            command.Execute(new string[] { "water", (-Coffee.WaterAmount).ToString() });
            Coffee = null;
            ExtraMilkAmount = 0;
            ExtraSugarAmount = 0;
        }

        public static void InitValidMoneyAmounts()
        {
            Database dataBase = new Database();

            string queryString = $"select * from money_items_db";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConection());

            dataBase.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ValidMoneyAmounts.Add(reader.GetInt32(2));
            }
            dataBase.CloseConnection();
        }
    }

}
