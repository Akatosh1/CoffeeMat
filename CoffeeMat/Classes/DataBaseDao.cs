using System.Data.SqlClient;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System;
using System.IO;
using System.Data;

namespace CoffeeMat.Classes
{
    // Класс отвечает за взаимодействие с бд
    internal class DataBaseDao
    {
        readonly Database dataBase = new Database();

        public string CheckResource(string resourceName, int addedResourceAmount)
        {
            string queryAmountString = $"select * from resource_items_db where resource_name='{resourceName}' ";
            SqlCommand amountCommand = new SqlCommand(queryAmountString, dataBase.GetConection());

            dataBase.OpenConnection();

            SqlDataReader reader = amountCommand.ExecuteReader();

            if (!reader.Read()) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];

            var amount = reader.GetInt32(2) + addedResourceAmount;
            var isLower = amount < reader.GetInt32(4);
            var isUpper = amount > reader.GetInt32(5);

            reader.Close();
            dataBase.CloseConnection();

            if (isLower) return string.Format(Locales.phrases[Locales.CurrentLocale]["NotEnoughResource"],
                    Locales.phrases[Locales.CurrentLocale][resourceName]);
            if (isUpper) return string.Format(Locales.phrases[Locales.CurrentLocale]["StorageIsFull"],
                    Locales.phrases[Locales.CurrentLocale][resourceName]);
            else return "";
        }

        public string FindResourceAmount(string resourceName)
        {

            string queryAmountString = $"select * from resource_items_db where resource_name='{resourceName}' ";

            SqlCommand amountCommand = new SqlCommand(queryAmountString, dataBase.GetConection());

            dataBase.OpenConnection();

            SqlDataReader reader = amountCommand.ExecuteReader();
            if(!reader.Read()) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            var amount = reader.GetInt32(2);

            reader.Close(); 
            dataBase.CloseConnection();

            return string.Format(
                Locales.phrases[Locales.CurrentLocale]["ResourceAmount"],
                resourceName,
                amount);
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
                    case "purchase":
                        list.Add(new Purchase(
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
            string queryString = $"insert into purchase_items_db(purchase_name, purchase_amount, picture) " +
                $"values ('{Order.Coffee.Name}', '{Order.Coffee.Amount}', @picture)";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConection());
            command.Parameters.Add("picture", SqlDbType.VarBinary).Value = ImageToByteArray(Order.Coffee.Picture);

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 0)
            {
                return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
            }
            dataBase.CloseConnection();

            return Order.GetChange();
        }

        public string UpdateResourceOnCoffee(string resourceName, int resourceChangeAmount)
        {
            string queryAmountString = $"select * from resource_items_db where resource_name='{resourceName}' ";

            SqlCommand amountCommand = new SqlCommand(queryAmountString, dataBase.GetConection());

            dataBase.OpenConnection();

            SqlDataReader reader = amountCommand.ExecuteReader();

            if (reader.Read())
            {
                var oldAmount = reader.GetInt32(2);
                var newAmount = oldAmount + resourceChangeAmount;
                reader.Close();
                if (newAmount < 0) return string.Format(Locales.phrases[Locales.CurrentLocale]["OutOfResource"], resourceName);
                dataBase.CloseConnection();

                if (Order.Coffee != null)
                {
                    if (resourceName == "milk")
                    {
                        Order.ExtraMilkAmount += 1;
                    }
                    if (resourceName == "sugar")
                    {
                        Order.ExtraSugarAmount += 1;
                    }
                    return Order.CreateOrderString();
                }
                else return Locales.phrases[Locales.CurrentLocale]["OrderNotFormed"];
            }
            else return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
        }
        public string UpdateResourceOnStorage(string resourceName, int resourceChangeAmount)
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
                if (newAmount < 0) return string.Format(Locales.phrases[Locales.CurrentLocale]["OutOfResource"], resourceName);
                if (command.ExecuteNonQuery() == 0) return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];
                dataBase.CloseConnection();

                if (Order.Coffee == null) return string.Format(
                    Locales.phrases[Locales.CurrentLocale]["ResourceAmount"],
                    resourceName,
                    newAmount);
                 else return Locales.phrases[Locales.CurrentLocale]["IncorrectRequest"];

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
            new Resource("blendedCoffee", 1000, Properties.Resources.кофейные_зерна).AddToBase();
            new Resource("plasticCups", 1000, Properties.Resources.кофе).AddToBase();
            new Resource("water", 1000, Properties.Resources.вода).AddToBase();
        }

        public byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
