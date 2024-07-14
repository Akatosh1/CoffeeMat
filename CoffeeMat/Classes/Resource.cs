using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace CoffeeMat.Classes
{
    internal class Resource: IItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Image Picture { get; set; }

        public Resource(string resourceName, int resourceAmount, Image image)
        {
            Name = resourceName;
            Amount = resourceAmount;
            Picture = image;
        }

        public bool AddToBase()
        {
            Database dataBase = new Database();

            string queryString = $"insert into " +
                $"resource_items_db(resource_name, resource_amount, picture) " +
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
