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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class ChangeCoffeeForm : Form
    {
        readonly Database dataBase = new Database();
        public ChangeCoffeeForm()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDeletePage();
        }

        private void CreateColumns()
        {
            CoffeeGridView.Columns.Add("id", "id");
            CoffeeGridView.Columns.Add("name", "имя");
            CoffeeGridView.Columns.Add("price", "цена");
            CoffeeGridView.Columns.Add("picture", "картинка");
            CoffeeGridView.Columns.Add("coffee", "кофе");
            CoffeeGridView.Columns.Add("water", "вода");
            CoffeeGridView.Columns.Add("milk", "молоко");
            CoffeeGridView.Columns.Add("isNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView view, SqlDataReader reader)
        {
            view.Rows.Add(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetInt32(2),
                reader.GetStream(3),
                reader.GetInt32(4),
                reader.GetInt32(5),
                reader.GetInt32(6));
        }

        private void RefreshDeletePage()
        {
            CoffeeGridView.Rows.Clear();
            string queryString = $"select * from coffee_items_db";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConection());
            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(CoffeeGridView, reader);
            }
            reader.Close();
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
