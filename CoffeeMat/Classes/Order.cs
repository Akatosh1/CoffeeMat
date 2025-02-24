﻿using CoffeeMat.Classes;
using CoffeeMat.Classes.Commands;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CoffeeMat
{
    public static class Order
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
                string.Format(Locales.GetLocales("Order"), Coffee.Name), 
                ExtraSugarAmount > 0 ? 
                string.Format(Locales.GetLocales("ExtraSugar"), ExtraSugarAmount) : "",
                ExtraMilkAmount > 0 ? 
                string.Format(Locales.GetLocales("ExtraMilk"), ExtraMilkAmount) : "");
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

        public static string GetChange()
        {
            var list = ValidMoneyAmounts.ToList();
            list.Sort();
            list.Reverse();

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Order.CreateOrderString());
            Order.Clear();

            if(CoffeeMachineBalance > 0)  
                stringBuilder.AppendLine(Locales.GetLocales("GiveChange"));

            while (list.Count > 0 && Order.CoffeeMachineBalance > 0) 
            {
                var higherElement = list[0];
                if(Order.CoffeeMachineBalance >= higherElement)
                {
                    Order.CoffeeMachineBalance -= higherElement;
                    stringBuilder.Append(higherElement.ToString());
                    stringBuilder.Append(" ");
                    stringBuilder.AppendLine(Locales.GetLocales("Rubles"));
                }
                else list.RemoveAt(0);
            }
            return stringBuilder.ToString();
        }
    }

}
