namespace Observer;

public class PlayerNew
{
    public string Name { get; set; }
    public int Health { get; set; }

    private List<IObserver<int>> observers = new();

    public PlayerNew(string name, int health)
    {
        Name = name;
        Health = health;
    }


    public void AddObserver(IObserver<int> obs)
    {
        observers.Add(obs);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} 受到 {damage} 伤害, 生命值现在为 {Health}");

        NotifyHealthChanged(Health);
    }

    public void NotifyHealthChanged(int health)
    {
        foreach (var obs in observers)
        {
            obs.OnNext(health);
        }
    }
}