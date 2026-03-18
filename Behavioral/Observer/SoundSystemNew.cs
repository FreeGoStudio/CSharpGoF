namespace Observer;

public class SoundSystemNew : IObserver<int>
{
    public void PlayDamageSound(int damage)
    {
        Console.WriteLine($"播放声音: 受到伤害的声音");
    }

    public void OnCompleted()
    {
        Console.WriteLine("角色死亡, 清除该组件运行");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine(error.Message);
    }

    public void OnNext(int value)
    {
        PlayDamageSound(value);
    }
}