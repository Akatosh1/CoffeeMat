using System.Drawing;

namespace CoffeeMat.Classes
{
    internal class Purchase : IItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Image Picture { get; set; }

        public Purchase(string name, int amount, Image picture) 
        { 
            Name = name;
            Amount = amount;
            Picture = picture;
        }

        public bool AddToBase()
        {
            DataBaseDao dataBaseDao = new DataBaseDao();

            return dataBaseDao.UpdateItemOnDataBase(this, "purchase");
        }
    }
}
