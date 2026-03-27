namespace Command.Command;

public class ReloadCommand : ICommand
{
    private Gun _gun;

    public ReloadCommand(Gun gun)
    {
        _gun = gun;
    }

    public void Execute()
    {
        _gun.Reload();
    }

    public void Undo()
    {
        Console.WriteLine("撤回重新填装");
    }
}