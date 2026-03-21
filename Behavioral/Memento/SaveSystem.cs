namespace Memento;

public class SaveSystem
{
    private PlayerMemento save;

    public void Save(PlayerNew player)
    {
        save = player.Save();
    }

    public void Load(PlayerNew player)
    {
        player.Load(save);
    }
}