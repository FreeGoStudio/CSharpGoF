namespace Bridge;

public class Rifle : Weapon
{
    public Rifle(IFireMode fireMode) : base(fireMode)
    {
    }

    public override void Shoot()
    {
        Console.Write("步枪");
        FireMode.Fire();
    }
}