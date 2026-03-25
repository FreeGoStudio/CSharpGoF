namespace Bridge;

public class Pistol : Weapon
{
    public Pistol(IFireMode fireMode) : base(fireMode)
    {
    }

    public override void Shoot()
    {
        Console.Write("手枪");
        FireMode.Fire();
    }
}