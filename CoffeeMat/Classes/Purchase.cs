using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat.Classes
{
    internal class Purchase : IItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Image Picture { get; set; }

        public Purchase(string name, int amount) 
        { 
            Name = name;
            Amount = amount;
            Picture = null;
        }
    }
}
