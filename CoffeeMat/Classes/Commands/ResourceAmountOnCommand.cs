namespace CoffeeMat.Classes.Commands
{
    public class ResourceAmountOnCommand : ICommand
    {
        public string Execute(string[] args)
        {
            if (args == null) return Locales.GetLocales("IncorrectRequest");
            var dataBaseDao = new DataBaseDao();
            return (args != null) ? dataBaseDao.FindResourceAmount(args[0]) : Locales.GetLocales("IncorrectRequest");
        }

        public string GetDescription()
        {
            return Locales.GetLocales("ResourceAmountOnCommandDescription");
        }
    }
}
