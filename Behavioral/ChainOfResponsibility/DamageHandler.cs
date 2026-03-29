namespace ChainOfResponsibility;

public abstract class DamageHandler
{
    private DamageHandler? _nextHandler;

    public DamageHandler SetNext(DamageHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public virtual void Handle(DamageNew damage)
    {
        _nextHandler?.Handle(damage);
    }
}