namespace Bridge;

public abstract class Weapon
{
    protected IFireMode FireMode;

    public Weapon(IFireMode fireMode)
    {
        FireMode = fireMode;
    }

    public abstract void Shoot();
}