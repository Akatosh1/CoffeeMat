using CoffeeMat.Classes;
using CoffeeMat.Classes.Commands;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeMat.Forms
{
    public partial class AddExtrasForm : Form
    {
        readonly DataBaseDao databaseDao = new DataBaseDao();
        public AddExtrasForm()
        {
            InitializeComponent();
            AddButtons();
        }

        public void AddButtons()
        {
            var SugarButton = GetStretchButton();
            var MilkButton = GetStretchButton();
            var AcceptButton = GetStretchButton();

            SugarButton.BackgroundImage = databaseDao.GetImageFromSql("sugar", "resource");
            SugarButton.BackgroundImageLayout = ImageLayout.Stretch;
            MilkButton.BackgroundImage = databaseDao.GetImageFromSql("milk", "resource");
            MilkButton.BackgroundImageLayout = ImageLayout.Stretch;
            AcceptButton.Text = "Оформить заказ";


            SugarButton.Click += (sender, EventArgs) =>
            { ItemClick(sender, EventArgs, new AddInCoffeeCommand(), new string[] { "sugar", "-1" });};
            MilkButton.Click += (sender, EventArgs) =>
            { ItemClick(sender, EventArgs, new AddInCoffeeCommand(), new string[] { "milk", "-1" }); };
            AcceptButton.Click += (sender, EventArgs) =>
            { ItemClick(sender, EventArgs, new ExecuteOrderCommand(), new string[] {}); };


            ExtrasTablePanel.Controls.Add(SugarButton);
            ExtrasTablePanel.Controls.Add(MilkButton);
            ExtrasTablePanel.Controls.Add(AcceptButton);
        }

        public Button GetStretchButton()
        {
            Button button = new Button
            {
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat
            };
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.Transparent;
            return button;
        }

        private void ItemClick(object _, EventArgs __, ICommand command, string[] param)
        {
            MessageBox.Show(command.Execute(param));
        }
    }
}
