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
            DataBaseDao dataBaseDao = new DataBaseDao();

            return dataBaseDao.UpdateItemOnDataBase(this, "money");
        }

        public byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
