/// <summary>
/// 适配器模式（Adapter Pattern）
/// 是一种 行为型设计模式。
/// 
/// 定义:
/// 把一个类的接口转换成客户端期望的另一个接口，让原本不兼容的类可以一起工作。
///
/// 结构:
/// Client → ITarget（IWeapon）
///             ↑
///          Adapter
///             ↓
///          Adaptee（LaserGun）
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
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用适配器模式的代码:");
    }
}