using System.Drawing;

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
    }
}
