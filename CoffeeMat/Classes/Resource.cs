using System.Drawing;

namespace CoffeeMat.Classes
{
    public class Resource: IItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Image Picture { get; set; }

        public int MINVALUE { get; set; }

        public int MAXVALUE { get; set; }

        const int MINVALUEDEFAULT = 0;
        const int MAXVALUEDEFAULT = 1000;

        public Resource(string resourceName, int resourceAmount, Image image)
        {
            Name = resourceName;
            Amount = resourceAmount;
            Picture = image;
            MINVALUE = MINVALUEDEFAULT;
            MAXVALUE = MAXVALUEDEFAULT;
        }

        public bool AddToBase()
        {
            DataBaseDao dataBaseDao = new DataBaseDao();

            return dataBaseDao.UpdateItemOnDataBase(this, "resource");
        }
    }
}
