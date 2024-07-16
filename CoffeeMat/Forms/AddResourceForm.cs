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
            AddPictureButton.Text = Locales.GetLocales("AddPicture");
            AddResourceItemButton.Text = Locales.GetLocales("Add");
            NameLabel.Text = Locales.GetLocales("Name");
            AmountLabel.Text = Locales.GetLocales("Price");
        }

        private void AddResourceButton_Click(object sender, EventArgs e)
        {
            var resourceDB = new Resource(ResourceNameBox.Text,
                int.Parse(ResourceAmountBox.Text),
                ResourcePictureBox.Image);

            if (resourceDB.AddToBase())
            {
                MessageBox.Show(Locales.GetLocales("Success"));
                AddResourceForm form1 = new AddResourceForm();
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show(Locales.GetLocales("AdditionError"));
            }
        }

        private void ResourceNameBox_TextChanged(object sender, EventArgs e)
        {
            if (ResourceNameBox.Text.Length > 50)
            {
                MessageBox.Show(Locales.GetLocales("OutOfSymbolsError"));
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
