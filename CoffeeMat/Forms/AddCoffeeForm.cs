using CoffeeMat.Classes;
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
            AddPictureButton.Text = Locales.GetLocales("AddPicture");
            AddCoffeeItemButton.Text = Locales.GetLocales("Add");
            NameLabel.Text = Locales.GetLocales("Name");
            PriceLabel.Text = Locales.GetLocales("Price");
            ReceiptLabel.Text = Locales.GetLocales("Receipt");
            CoffeeLabel.Text = Locales.GetLocales("blendedCoffee");
            WaterLabel.Text = Locales.GetLocales("water");
            MilkLabel.Text = Locales.GetLocales("milk");
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
                Convert.ToInt32(NumericPrice.Value), 
                PictureBox.Image,
                Convert.ToInt32(CoffeeNumeric.Value),
                Convert.ToInt32(WaterNumeric.Value),
                Convert.ToInt32(MilkNumeric.Value));

            if (coffeeDB.AddToBase())
            {
                MessageBox.Show(Locales.GetLocales("Success"));
                AddCoffeeForm form = new AddCoffeeForm
                {
                    Location = this.Location,
                    Size = this.Size,
                    StartPosition = FormStartPosition.Manual
                };
                form.FormClosing += delegate { this.Show(); };
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(Locales.GetLocales("AdditionError"));
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (NameBox.Text.Length > 50)
            {                
                MessageBox.Show(Locales.GetLocales("OutOfSymbolsError"));
                NameBox.Text = "";
            }
        }
    }
}
