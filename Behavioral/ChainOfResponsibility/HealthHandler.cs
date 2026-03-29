namespace ChainOfResponsibility;

public class HealthHandler : DamageHandler
{
    public override void Handle(DamageNew damage)
    {
        var target = damage.Target;

        target.Health -= damage.Value;
        Console.WriteLine($"角色当前生命值{target.Health}");
        if (target.Health <= 0)
        {
            target.Die();
        }

        base.Handle(damage);
    }
}