namespace CoffeeMat.Classes.Commands
{
    internal class AddMoneyCommand : ICommand
    {
        public string Execute(string[] args)
        {
            if (args == null) return Locales.GetLocales("IncorrectRequest");
            if (int.TryParse(args[0],out int arg))
            {
                if (!Order.ValidMoneyAmounts.Contains(arg)) return Locales.GetLocales("NoMoney");

                Order.CoffeeMachineBalance += arg;
                return string.Format(Locales.phrases[Locales.CurrentLocale]["Balance"], Order.CoffeeMachineBalance);
            }
            else
            {
                return Locales.GetLocales("IncorrectRequest");
            }
        }

        public string GetDescription()
        {
            return Locales.GetLocales("AddMoneyCommandDescription");
        }
    }
}
