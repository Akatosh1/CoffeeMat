using CoffeeMat.Classes;
using CoffeeMat.Classes.Commands;
using CoffeeMat.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CoffeeMat
{
    public partial class StartScreen : Form
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        readonly IntPtr handle = GetConsoleWindow();

        public StartScreen()
        {
            InitializeComponent();
            ShowWindow(handle, SW_HIDE);
            AddButtons();
        }

        private void AddButtons()
        {
            var controls = new Dictionary<string, EventHandler>();
            controls.Add("Поменять локализацию", ChangeLocalesButton_Click);
            controls.Add("Запуск кофе машины", CoffeeMachineButton_Click);
            controls.Add("Редактирование видов кофе", CoffeeFormattingButton_Click);
            controls.Add("Работа с консолью", ConsoleButton_Click);
            controls.Add("Список заказов", ShowOrdersButton_click);
            startTableLayout.Controls.Clear();

            foreach (var control in controls.Keys)
            {
                var button = GetStretchButton(control);
                button.Click += controls[control];
                startTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                startTableLayout.Controls.Add(button);
            }           
        }

        private void CoffeeMachineButton_Click(object sender, EventArgs e)
        {
            RedirectForm(new CoffeeMachine());
        }

        private void CoffeeFormattingButton_Click(object sender, EventArgs e)
        {
            RedirectForm(new ChangeCoffeeForm());
        }

        private void ChangeLocalesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new ChangeLocalesCommand().Execute(null));
        }

        private void ShowOrdersButton_click(object sender, EventArgs e)
        {
            RedirectForm(new ShowOrderForm());
        }

        private void RedirectForm(Form redirectForm)
        {
            var form = redirectForm;
            form.Location = this.Location;
            form.Size = this.Size;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private Button GetStretchButton(string text)
        {
            Button button = new Button
            {
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat
            };
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.Transparent;
            button.Text = text;
            return button;
        }

        private void ConsoleButton_Click(object sender, EventArgs e)
        {
            ShowWindow(handle, SW_SHOW);
            string command;
            var coffeeConsoleManager = new CoffeeConsoleManager();
            coffeeConsoleManager.InitCommands();
            while ((command = Console.ReadLine()) != "exit")
            {
                Console.WriteLine(coffeeConsoleManager.GetCommand(command));
            }
        }
    }
}
