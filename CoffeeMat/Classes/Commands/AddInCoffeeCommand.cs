namespace CoffeeMat.Classes.Commands
{
    public class AddInCoffeeCommand : ICommand
    {

        public string Execute(string[] args)
        {
            if (args == null) return Locales.GetLocales("IncorrectRequest");
            if (args.Length != 2) return Locales.GetLocales("IncorrectRequest");
            if (!int.TryParse(args[1], out int amount)) return Locales.GetLocales("IncorrectRequest");

            var dataBaseDao = new DataBaseDao();
            var checkString = dataBaseDao.CheckResource(args[0], -1);
            if (checkString.Length != 0) return checkString;
                
            return dataBaseDao.UpdateResourceOnCoffee(args[0], amount);
        }

        public string GetDescription()
        {
            return Locales.GetLocales("AddInCoffeeCommandDescription");
        }
    }
}
