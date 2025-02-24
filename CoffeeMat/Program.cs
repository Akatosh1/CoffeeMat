﻿using CoffeeMat.Classes;
using CoffeeMat.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMat
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var dataBaseDao = new DataBaseDao();
            dataBaseDao.AddFullItems();
            Locales.CreateLocales();
            Order.InitValidMoneyAmounts();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
