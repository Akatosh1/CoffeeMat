using CoffeeMat.Classes;
using System.Drawing;

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

        public Coffee(string name, int amount, Image picture, int coffee, int water, int milk)
        {
            Name = name;
            Amount = amount;
            Picture = picture;
            CoffeeAmount = coffee;
            WaterAmount = water;
            MilkAmount = milk;
        }

        public bool AddToBase()
        {
            DataBaseDao dataBaseDao = new DataBaseDao();

            return dataBaseDao.UpdateItemOnDataBase(this, "coffee");
        }
    }
}
