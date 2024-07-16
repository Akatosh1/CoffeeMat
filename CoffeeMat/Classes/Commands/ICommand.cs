namespace CoffeeMat.Classes.Commands
{
    public interface ICommand
    {
        string GetDescription();

        string Execute(string[] args);
    }
}
