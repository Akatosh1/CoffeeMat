using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace CoffeeMat.Classes
{
    internal class Money: IItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Image Picture { get; set; }

        public Money(string coffeeName, int amount, Image picture)
        {
            Name = coffeeName;
            Amount = amount;
            Picture = picture;
        }

        public bool AddToBase()
        {
            Database dataBase = new Database();

            string queryString = $"insert into " +
                $"money_items_db(money_name, money_amount, picture) " +
                $"values ('{this.Name}', " +
                $"'{this.Amount}', " +
                $"@picture)";

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
