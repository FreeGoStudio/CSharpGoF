using Command.Command;

namespace Command;

public class PlayerNew
{
    private ICommand _shootCommand;
    private ICommand _reloadCommand;

    private Stack<ICommand> _undoStack = new();

    public void SetCommand(ICommand shootCommand, ICommand reloadCommand)
    {
        _shootCommand = shootCommand;
        _reloadCommand = reloadCommand;
    }

    public void Shoot()
    {
        _shootCommand.Execute();
        _undoStack.Push(_shootCommand);
    }

    public void Reload()
    {
        _reloadCommand.Execute();
        _undoStack.Push(_reloadCommand);
    }

    public void Undo()
    {
        var command = _undoStack.Pop();
        command.Undo();
    }
}