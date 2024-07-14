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
                int.Parse(AmountBox.Text),
                MoneyPictureBox.Image);

            if (moneyDB.AddToBase())
            {
                MessageBox.Show("Успешно");
                AddMoneyForm form1 = new AddMoneyForm();
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неудача");
            }
        }

        private void MoneyNameBox_TextChanged(object sender, EventArgs e)
        {
            if (MoneyNameBox.Text.Length > 20)
            {
                MessageBox.Show("Название должно быть короче 20 символов");
                MoneyNameBox.Text = "";
            }
        }

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(AmountBox.Text, out int amount))
            {
                MessageBox.Show("Ценность должна быть целым числом");
                AmountBox.Text = "";
            }
        }
    }
}
