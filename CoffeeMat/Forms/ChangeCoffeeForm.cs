using CoffeeMat.Classes;
using System;
using System.Linq;
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
            RefreshPage();
        }

        private void CreateColumns()
        {
            CoffeeGridView.Columns.Add("name", Locales.GetLocales("Name"));
            CoffeeGridView.Columns.Add("price", Locales.GetLocales("Price"));
            CoffeeGridView.Columns.Add("picture", Locales.GetLocales("Picture"));
            CoffeeGridView.Columns.Add("coffee", Locales.GetLocales("blendedCoffee"));
            CoffeeGridView.Columns.Add("water", Locales.GetLocales("water"));
            CoffeeGridView.Columns.Add("milk", Locales.GetLocales("milk"));
        }

        private void RefreshPage()
        {
            CoffeeGridView.Rows.Clear();
           

            foreach (Coffee coffee in dataBaseDao.GetSqlTableList("coffee").Cast<Coffee>())
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
            var form = new AddCoffeeForm
            {
                Location = this.Location,
                Size = this.Size,
                StartPosition = FormStartPosition.Manual
            };
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
    }
}
