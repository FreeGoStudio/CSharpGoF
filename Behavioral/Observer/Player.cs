namespace Observer;

public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }

    public UiSystem UI { get; set; }
    public SoundSystem Sound { get; set; }

    public Player(string name, int health, UiSystem ui, SoundSystem sound)
    {
        Name = name;
        Health = health;
        UI = ui;
        Sound = sound;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} 受到 {damage} 伤害, 生命值现在为 {Health}");

        UI.UpdateHealthBar(Health); // 通知UI系统更新
        Sound.PlayDamageSound(Health); // 通知声音系统播放声音
    }
}