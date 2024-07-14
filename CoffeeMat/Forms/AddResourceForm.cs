using CoffeeMat.Classes;
using System;
using System.Windows.Forms;

namespace CoffeeMat.Forms
{
    public partial class AddResourceForm : Form
    {
        public AddResourceForm()
        {
            InitializeComponent();
        }

        private void AddResourceButton_Click(object sender, EventArgs e)
        {
            var resourceDB = new Resource(ResourceNameBox.Text,
                int.Parse(ResourceAmountBox.Text),
                ResourcePictureBox.Image);

            if (resourceDB.AddToBase())
            {
                MessageBox.Show("Успешно");
                AddResourceForm form1 = new AddResourceForm();
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неудача");
            }
        }

        private void ResourceNameBox_TextChanged(object sender, EventArgs e)
        {
            if (ResourceNameBox.Text.Length > 20)
            {
                MessageBox.Show("Название должно быть короче 20 символов");
                ResourceNameBox.Text = "";
            }
        }


        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            if (ResourcePictureAddDialog.ShowDialog() == DialogResult.OK)
            {
                ResourcePictureBox.Load(ResourcePictureAddDialog.FileName);
            }
            ResourcePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
