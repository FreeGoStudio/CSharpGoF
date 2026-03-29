namespace ChainOfResponsibility;

public class ArmorHandler : DamageHandler
{
    public override void Handle(DamageNew damage)
    {
        if (damage.Type != DamageType.Physical)
        {
            return;
        }

        var target = damage.Target;

        damage.Value -= target.Armor;
        if (damage.Value < 0)
        {
            damage.Value = 0;
        }

        base.Handle(damage);
    }
}