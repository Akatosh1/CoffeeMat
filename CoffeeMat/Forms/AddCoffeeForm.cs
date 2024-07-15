using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoffeeMat
{
    public partial class AddCoffeeForm : Form
    {
        public AddCoffeeForm()
        {
            InitializeComponent();
        }

        private void PictureAddButton_Click(object sender, EventArgs e)
        {
            if (CoffeePictureAddDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Load(CoffeePictureAddDialog.FileName);
            }
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var coffeeDB = new Coffee(NameBox.Text,
                int.Parse(PriceBox.Text), 
                PictureBox.Image,
                Convert.ToInt32(CoffeeNumeric.Value),
                Convert.ToInt32(WaterNumeric.Value),
                Convert.ToInt32(MilkNumeric.Value));

            if (coffeeDB.AddToBase())
            {
                MessageBox.Show("Успешно");
                AddCoffeeForm form = new AddCoffeeForm();
                form.Location = this.Location;
                form.Size = this.Size;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Show(); };
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неудача");
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (NameBox.Text.Length > 20)
            {
                MessageBox.Show("Название должно быть короче 20 символов");
                NameBox.Text = "";
            }
        }

    }
}
