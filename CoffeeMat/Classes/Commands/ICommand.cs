namespace CoffeeMat.Classes.Commands
{
    internal interface ICommand
    {
        string GetDescription();

        string Execute(string[] args);
    }
}
