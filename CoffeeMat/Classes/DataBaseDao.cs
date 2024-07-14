using System.Data.SqlClient;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System;
using System.IO;

namespace CoffeeMat.Classes
{
    internal class DataBaseDao
    {
        readonly Database dataBase = new Database();

        public string FindResourceAmount(string resourceName)
        {

            string queryAmountString = $"select * from resource_items_db where resource_name='{resourceName}' ";

            SqlCommand amountCommand = new SqlCommand(queryAmountString, dataBase.GetConection());

            dataBase.OpenConnection();

            SqlDataReader reader = amountCommand.ExecuteReader();
            reader.Read();
            var amount = reader.GetInt32(2);

            dataBase.CloseConnection();

            return $"Количество '{resourceName}' '{amount}'";
        }

        public List<IItem> GetSqlTableList(string tableName)
        {
            var list = new List<IItem>();
            string queryString = $"select * from {tableName}_items_db";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = reader.GetString(1);
                var amount = reader.GetInt32(2);
                var image = Image.FromStream(reader.GetStream(3));
                switch (tableName)
                {
                    case "coffee":
                        list.Add(new Coffee(
                        name,
                        amount,
                        image,
                        reader.GetInt32(4),
                        reader.GetInt32(5),
                        reader.GetInt32(6)
                        ));
                        break;
                    case "resource":
                        list.Add(new Resource(
                        name,
                        amount,
                        image
                        ));
                        break ;
                    case "money":
                        list.Add(new Money(
                        name,
                        amount,
                        image
                        ));
                        break;
                }              
            }

            reader.Close();
            dataBase.CloseConnection();

            return list;
        }

        public Coffee GetCoffeeFromSql(string coffeeName)
        {
            Coffee coffeeItem = null;
            string queryString = $"select * from coffee_items_db where coffee_name='{coffeeName}'";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) coffeeItem = new Coffee(
                reader.GetString(1),
                reader.GetInt32(2),
                Image.FromStream(reader.GetStream(3)),
                reader.GetInt32(4),
                reader.GetInt32(5),
                reader.GetInt32(6));

            
            reader.Close();
            dataBase.CloseConnection();
            return coffeeItem;
        }

        public Image GetImageFromSql(string sourceName, string databaseName) 
        {
            Image image = null;
            string queryString = $"select * from {databaseName}_items_db Where {databaseName}_name='{sourceName}'";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) image = Image.FromStream(reader.GetStream(3));

            reader.Close();
            dataBase.CloseConnection();

            return image;
        }

        public string UpdateOnOrder()
        {
            string queryString = $"insert into purchase_items_db(purchase_name, price) " +
                $"values ('{Order.Coffee.Name}', '{Order.Coffee.Amount}')";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConection());

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 0)
            {
                return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            }
            dataBase.CloseConnection();
            return Order.CreateOrderString();
        }

        public string UpdateOnResource(string resourceName, int resourceChangeAmount)
        {

            string queryString = $"update resource_items_db set resource_amount = resource_amount+'{resourceChangeAmount}' where resource_name='{resourceName}'";
            string queryAmountString = $"select * from resource_items_db where resource_name='{resourceName}' ";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConection());
            SqlCommand amountCommand = new SqlCommand(queryAmountString, dataBase.GetConection());

            dataBase.OpenConnection();

            SqlDataReader reader = amountCommand.ExecuteReader();

            if (reader.Read())
            {
                var oldAmount = reader.GetInt32(2);
                var newAmount = oldAmount + resourceChangeAmount;
                reader.Close();
                if (newAmount < 0) return $"Ресурс '{resourceName}' закончился";
                if (command.ExecuteNonQuery() == 0) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
                dataBase.CloseConnection();
                return Order.Coffee != null ? Order.CreateOrderString(): $"Количество '{resourceName}' '{newAmount}'";
            }
            else return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
        }

        public void AddFullItems()
        {
            new Coffee("Americano", 10, Properties.Resources.американо, 1, 2, 0).AddToBase();
            new Coffee("Cappucino", 15, Properties.Resources.капучино, 1, 1, 1).AddToBase();
            new Coffee("Latte", 25, Properties.Resources.Латте, 1, 1, 2).AddToBase();
            new Coffee("Espresso", 20, Properties.Resources.эспрессо, 1, 1, 0).AddToBase();
            new Money("1 ruble", 1, Properties.Resources._1рубль_монета).AddToBase();
            new Money("2 rubles", 2, Properties.Resources._2_рублямонета).AddToBase();
            new Money("5 rubles", 5, Properties.Resources._5_рублей_монета).AddToBase();
            new Money("10 rubles", 10, Properties.Resources._10_рублей_монета).AddToBase();
            new Money("10 rubles", 10, Properties.Resources._10_рублей_купюра).AddToBase();
            new Money("50 rubles", 50, Properties.Resources._50_рублей_купюра).AddToBase();
            new Money("100 rubles", 100, Properties.Resources._100_рублей_купюра).AddToBase();
            new Money("200 rubles", 200, Properties.Resources._200_рублей_купюра).AddToBase();
            new Resource("sugar", 1000, Properties.Resources.сахар).AddToBase();
            new Resource("milk", 1000, Properties.Resources.молоко).AddToBase();
            new Resource("BlendedCoffee", 1000, Properties.Resources.кофейные_зерна).AddToBase();
            new Resource("plasticCups", 1000, Properties.Resources.кофе).AddToBase();
            new Resource("water", 1000, Properties.Resources.вода).AddToBase();
        }

        
    }
}
