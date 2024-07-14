using CoffeeMat.Classes;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace CoffeeMat
{
    internal class Coffee : IItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Image Picture { get; set; }
        public int CoffeeAmount { get; set; }
        public int WaterAmount { get; set; }
        public int MilkAmount { get; set; }

        public Coffee(string name, int price, Image picture, int coffee, int water, int milk)
        {
            Name = name;
            Amount = price;
            Picture = picture;
            CoffeeAmount = coffee;
            WaterAmount = water;
            MilkAmount = milk;
        }

        public bool AddToBase()
        {
            Database dataBase = new Database();

            string queryString = $"insert into " +
                $"coffee_items_db(coffee_name, price, picture, coffee, water, milk) " +
                $"values ('{this.Name}', " +
                $"'{this.Amount}', " +
                $"@picture, " +
                $"'{this.CoffeeAmount}', " +
                $"'{this.WaterAmount}', " +
                $"'{this.MilkAmount}')";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConection());
            command.Parameters.Add("picture", SqlDbType.VarBinary).Value = ImageToByteArray(this.Picture);

            dataBase.OpenConnection();
            var answ = command.ExecuteNonQuery();
            dataBase.CloseConnection();
            return (answ == 1);
        }
        public byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
