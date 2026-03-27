namespace Command;

public class Player
{
    public Gun? Gun { get; set; }

    public void Shoot()
    {
        Gun?.Shoot();
    }

    public void Reload()
    {
        Gun?.Reload();
    }
}