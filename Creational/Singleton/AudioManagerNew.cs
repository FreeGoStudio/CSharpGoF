namespace Singleton;

public class AudioManagerNew
{
    public static AudioManagerNew Instance { get; } = new();

    private AudioManagerNew()
    {
    }

    public void Play(string sound)
    {
        Console.WriteLine($"播放{sound}");
    }
}