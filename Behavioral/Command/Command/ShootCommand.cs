namespace Command.Command;

public class ShootCommand : ICommand
{
    private Gun _gun;

    public ShootCommand(Gun gun)
    {
        _gun = gun;
    }

    public void Execute()
    {
        _gun.Shoot();
    }

    public void Undo()
    {
        Console.WriteLine("撤回射击");
    }
}