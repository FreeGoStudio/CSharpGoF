namespace ChainOfResponsibility;

public class CombatSystem
{
    private DamageHandler _damageHandler;

    public CombatSystem()
    {
        _damageHandler = new ShieldHandler();
        _damageHandler.SetNext(new ArmorHandler())
                      .SetNext(new HealthHandler());
    }

    public void ApplyDamage(DamageNew damage)
    {
        _damageHandler.Handle(damage);
    }
}