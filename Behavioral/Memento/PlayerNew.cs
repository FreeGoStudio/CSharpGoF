namespace Memento;

public class PlayerNew
{
    public int Health;
    public int Ammo;

    public PlayerMemento Save()
    {
        return new PlayerMemento(Health, Ammo);
    }

    public void Load(PlayerMemento memento)
    {
        Health = memento.Health;
        Ammo = memento.Ammo;
    }
}