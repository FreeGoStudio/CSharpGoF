namespace Memento;

public class PlayerMemento
{
    public int Health { get; }
    public int Ammo { get; }

    public PlayerMemento(int health, int ammo)
    {
        Health = health;
        Ammo = ammo;
    }
}