namespace Bridge;

public class SingleFire : IFireMode
{
    public void Fire()
    {
        Console.WriteLine("单发射击");
    }
}