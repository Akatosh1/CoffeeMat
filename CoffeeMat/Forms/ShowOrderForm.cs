using CoffeeMat.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMat.Forms
{
    public partial class ShowOrderForm : Form
    {
        readonly DataBaseDao dataBaseDao = new DataBaseDao();
        public ShowOrderForm()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDeletePage();
        }

        private void CreateColumns()
        {
            PurchaseGridView.Columns.Add("name", "имя");
            PurchaseGridView.Columns.Add("price", "цена");
            PurchaseGridView.Columns.Add("picture", "картинка");
        }

        private void RefreshDeletePage()
        {
            PurchaseGridView.Rows.Clear();


            foreach (Purchase coffee in dataBaseDao.GetSqlTableList("purchase"))
            {
                PurchaseGridView.Rows.Add(
                coffee.Name,
                coffee.Amount,
                coffee.Picture);
            }
        }
    }
}
