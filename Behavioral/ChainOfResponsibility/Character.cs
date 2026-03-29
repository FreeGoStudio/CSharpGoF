namespace ChainOfResponsibility;

public class Character(float health, float armor, float shield)
{
    private float _health = health;
    private float _shield = shield;

    private float Shield
    {
        get => _shield;
        set => _shield = value < 0 ? 0 : value;
    }

    private bool HasShield => Shield > 0;

    public void HandleDamage(Damage damage)
    {
        if (HasShield)
        {
            HandleShield(damage);
        }

        HandleArmor(damage);

        HandleHealth(damage);
    }

    private void HandleShield(Damage damage)
    {
        damage.Value -= Shield;
        if (damage.Value < 0)
        {
            damage.Value = 0;
        }

        Shield -= damage.Value;
    }

    private void HandleArmor(Damage damage)
    {
        if (damage.Type != DamageType.Physical)
        {
            return;
        }

        damage.Value -= armor;
        if (damage.Value < 0)
        {
            damage.Value = 0;
        }
    }

    private void HandleHealth(Damage damage)
    {
        _health -= damage.Value;
        Console.WriteLine($"角色当前生命值{_health}");
        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Console.WriteLine("角色死了");
    }
}