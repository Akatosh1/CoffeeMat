using CoffeeMat.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMat
{

    public partial class ChangeCoffeeForm : Form
    {
        readonly DataBaseDao dataBaseDao = new DataBaseDao();
        public ChangeCoffeeForm()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDeletePage();
        }

        private void CreateColumns()
        {
            CoffeeGridView.Columns.Add("name", "имя");
            CoffeeGridView.Columns.Add("price", "цена");
            CoffeeGridView.Columns.Add("picture", "картинка");
            CoffeeGridView.Columns.Add("coffee", "кофе");
            CoffeeGridView.Columns.Add("water", "вода");
            CoffeeGridView.Columns.Add("milk", "молоко");
        }

        private void RefreshDeletePage()
        {
            CoffeeGridView.Rows.Clear();
           

            foreach (Coffee coffee in dataBaseDao.GetSqlTableList("coffee"))
            {
                CoffeeGridView.Rows.Add(
                coffee.Name,
                coffee.Amount,
                coffee.Picture,
                coffee.CoffeeAmount,
                coffee.WaterAmount,
                coffee.MilkAmount);
            }
        }

        private void NewCoffeeButton_Click(object sender, EventArgs e)
        {
            var form = new AddCoffeeForm();
            form.Location = this.Location;
            form.Size = this.Size;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
    }
}
