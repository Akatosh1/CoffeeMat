namespace CoffeeMat.Classes.Commands
{
    public class FillResourceOnCommand : ICommand
    {
        public string Execute(string[] args)
        {
            if (args == null) return Locales.GetLocales("IncorrectRequest");
            if (!int.TryParse(args[1], out int amount)) return Locales.GetLocales("IncorrectRequest");
            var dataBaseDao = new DataBaseDao();

            var checkString = dataBaseDao.CheckResource(args[0], amount);
            if (checkString.Length != 0) return checkString;
                

            return dataBaseDao.UpdateResourceOnStorage(args[0], amount);
        }

        public string GetDescription()
        {
            return Locales.GetLocales("FillResourceCommandDescription");
        }
    }
}
