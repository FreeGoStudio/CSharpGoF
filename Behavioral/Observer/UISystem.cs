namespace Observer;

public class UiSystem
{
    public void UpdateHealthBar(int health)
    {
        Console.WriteLine($"更新UI: 生命值现在为 {health}");
    }
}