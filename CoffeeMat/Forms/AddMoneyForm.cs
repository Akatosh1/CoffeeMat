using CoffeeMat.Classes;
using System;
using System.Windows.Forms;

namespace CoffeeMat.Forms
{
    public partial class AddMoneyForm : Form
    {
        public AddMoneyForm()
        {
            InitializeComponent();
            AddPictureButton.Text = Locales.GetLocales("AddPicture");
            AddMoneyItemButton.Text = Locales.GetLocales("Add");
            NameLabel.Text = Locales.GetLocales("Name");
            AmountLabel.Text = Locales.GetLocales("Price");
        }

        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            if (MoneyPictureAddDialog.ShowDialog() == DialogResult.OK)
            {
                MoneyPictureBox.Load(MoneyPictureAddDialog.FileName);
            }
            MoneyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void AddMoneyExampleButton_Click(object sender, EventArgs e)
        {
            var moneyDB = new Money(MoneyNameBox.Text,
                Convert.ToInt32(AmountNumeric),
                MoneyPictureBox.Image);

            if (moneyDB.AddToBase())
            {
                MessageBox.Show(Locales.GetLocales("Success"));
                AddMoneyForm form1 = new AddMoneyForm();
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show(Locales.GetLocales("AdditionError"));
            }
        }

        private void MoneyNameBox_TextChanged(object sender, EventArgs e)
        {
            if (MoneyNameBox.Text.Length > 50)
            {
                MessageBox.Show(Locales.GetLocales("OutOfSymbolsError"));
                MoneyNameBox.Text = "";
            }
        }

    }
}
