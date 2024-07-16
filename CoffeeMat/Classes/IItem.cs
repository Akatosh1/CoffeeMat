using System.Drawing;

namespace CoffeeMat.Classes
{
    public interface IItem   {
        string Name { get; set; }
        int Amount { get; set; }
        Image Picture { get; set; }

        bool AddToBase();
    }
}
