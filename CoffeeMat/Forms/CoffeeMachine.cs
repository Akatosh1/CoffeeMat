using CoffeeMat.Classes;
using CoffeeMat.Classes.Commands;
using CoffeeMat.Forms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CoffeeMat
{
    public partial class CoffeeMachine : Form
    {
        readonly DataBaseDao dataBaseDao = new DataBaseDao();

        public CoffeeMachine()
        {
            InitializeComponent();
            RefreshCoffeeItems();
            RefreshMoneyItems();
        }

        private void RefreshCoffeeItems()
        {
            CoffeeTablePanel.Controls.Clear();
            var coffeeList = dataBaseDao.GetSqlTableList("coffee");

            foreach(var coffee in coffeeList)
            {
                CoffeeTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                var button = CreateSingleButton(coffee.Name, coffee.Picture);
                button.Click += (sender, EventArgs) =>
                { CoffeeItemClick(sender, EventArgs, coffee.Name); };
                CoffeeTablePanel.Controls.Add(button);
            }
        }

        private void RefreshMoneyItems()
        {
            MoneyTablePanel.Controls.Clear();
            var moneyList = dataBaseDao.GetSqlTableList("money");

            foreach(var money in moneyList)
            {
                MoneyTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                var button = CreateSingleButton(money.Amount.ToString(), money.Picture);
                button.Click  += (sender,EventArgs) => 
                { MoneyItemClick(sender, EventArgs, money.Amount.ToString()); };
                MoneyTablePanel.Controls.Add(button);             
            }    

        }

        private Button CreateSingleButton(string name, Image image)
        {
            var button = GetStretchButton();

            button.BackgroundImage = image;
            button.BackgroundImageLayout = ImageLayout.Stretch;

            button.Text = name;
            button.TextAlign = ContentAlignment.TopLeft;
            
            return button;
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

        private void CoffeeItemClick(object _, EventArgs __, string param)
        {
            var coffee = dataBaseDao.GetCoffeeFromSql(param);
            if (Order.CoffeeMachineBalance < coffee.Amount)
            {
                MessageBox.Show("Недостаточно денег на балансе", "Предупреждение");
            }
            else
            {
                Order.Coffee = coffee;
                DialogResult dialogResult = MessageBox.Show("Желаете добавить что-то к заказу?", "Выбор", MessageBoxButtons.YesNo);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        {
                            var form = new AddExtrasForm
                            {
                                Location = this.Location,
                                Size = this.Size,
                                StartPosition = FormStartPosition.Manual
                            };
                            form.FormClosing += delegate { this.Show(); };
                            form.Show();
                            this.Hide();
                            break;
                        }
                    case DialogResult.No:
                        new ExecuteOrderCommand().Execute(new string[] {});
                        break;
                }
            }
        }

        private void MoneyItemClick(object _, EventArgs __, string param)
        {
            MessageBox.Show(new AddMoneyCommand().Execute(new string[] {param}));
        }
    }
}
