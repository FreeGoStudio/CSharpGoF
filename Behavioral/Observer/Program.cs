namespace Observer;

internal class Program
{
    /// <summary>
    /// 观察者模式（Observer Pattern）
    /// 是一种 行为型设计模式。
    /// 
    /// 核心思想:
    /// 
    /// </summary>
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
        Console.WriteLine("\n使用观察者模式的代码:");
    }
}