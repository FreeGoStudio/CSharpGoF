namespace Proxy;

/// <summary>
/// 代理模式 (Proxy Pattern)
/// 一种 结构型设计模式 
///
/// 核心思想:
/// 用一个“代理对象”控制对真实对象的访问。
///
/// 注意:
/// 客户端不直接访问真实对象，而是通过 Proxy。
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