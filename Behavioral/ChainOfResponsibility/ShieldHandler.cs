namespace ChainOfResponsibility;

public class ShieldHandler : DamageHandler
{
    public override void Handle(DamageNew damage)
    {
        var target = damage.Target;

        if (target.Shield <= 0)
        {
            base.Handle(damage);
            return;
        }

        damage.Value -= target.Shield;
        if (damage.Value < 0)
        {
            damage.Value = 0;
        }

        target.Shield -= damage.Value;

        base.Handle(damage);
    }
}