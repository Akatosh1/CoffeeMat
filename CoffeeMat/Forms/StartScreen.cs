using CoffeeMat.Classes;
using CoffeeMat.Forms;
using System;
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
            Order.InitValidMoneyAmounts();
        }

        private void CoffeeMachineButton_Click(object sender, EventArgs e)
        {
            RedirectForm(new CoffeeMachine());
        }

        private void CoffeeFormattingButton_Click(object sender, EventArgs e)
        {
            RedirectForm(new ChangeCoffeeForm());
        }

        private void FillResoucesButton_Click(object sender, EventArgs e)
        {
            RedirectForm(new ResourcesForm());
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
