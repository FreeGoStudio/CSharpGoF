namespace Observer;

public class UiSystemNew : IObserver<int>
{
    public void UpdateHealthBar(int health)
    {
        Console.WriteLine($"更新UI: 生命值现在为 {health}");
    }

    public void OnCompleted()
    {
        Console.WriteLine("玩家已死亡，UI系统完成更新");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine(error.Message);
    }

    public void OnNext(int value)
    {
        UpdateHealthBar(value);
    }
}