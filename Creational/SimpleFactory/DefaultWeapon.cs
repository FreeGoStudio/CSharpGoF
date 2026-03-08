namespace SimpleFactory;

public class DefaultWeapon : IWeapon
{
    public void Use()
    {
        Console.WriteLine("徒手攻击!");
    }
}