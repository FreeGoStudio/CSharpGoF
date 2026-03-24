namespace Singleton;

/// <summary>
/// 单例模式（Singleton Pattern）
/// 是一种 创建型设计模式。
/// 
/// 定义:
/// 保证一个类只有一个实例，并提供一个全局访问点。
/// “全世界只有一个，而且大家都能访问它”
/// ❗单例解决的不是“能不能 new”，而是“访问方式 + 依赖关系”
///
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //未使用设计模式
        UnusedDesignPattern();

        //使用设计模式
        UsedDesignPattern();
    }

    private static void UnusedDesignPattern()
    {
        Console.WriteLine("\n未使用设计模式的代码:");

        var audio = new AudioManager();
        audio.Play("gun_shot");
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用单例模式的代码:");

        AudioManagerNew.Instance.Play("gun_shot");
    }
}