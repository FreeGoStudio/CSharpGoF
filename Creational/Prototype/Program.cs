namespace Prototype;

/// <summary>
/// 代理模式 (Proxy Pattern)
/// 一种 创建型设计模式 
///
/// 核心思想:
/// 通过复制（Clone）已有对象来创建新对象，而不是用 new。
///
/// 注意:
/// 不是创建对象, 而是复制对象
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //未使用简单工厂模式
        UnusedDesignPattern();

        //使用简单工厂模式
        UsedDesignPattern();
    }

    private static void UnusedDesignPattern()
    {
    }

    private static void UsedDesignPattern()
    {
    }
}