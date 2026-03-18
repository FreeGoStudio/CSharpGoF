namespace Observer;

public class PlayerUsedEvent
{
    public string Name { get; set; }
    public int Health { get; set; }
    public event Action<int>? OnHealthChanged;

    public PlayerUsedEvent(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} 受到 {damage} 伤害, 生命值现在为 {Health}");

        OnHealthChanged?.Invoke(Health);
    }
}