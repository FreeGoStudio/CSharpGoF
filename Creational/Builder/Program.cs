namespace Builder;

internal class Program
{
    /// <summary>
    /// 建造者模式（Builder Pattern）
    /// 是一种 创建型设计模式。
    /// 
    /// 核心思想:
    /// 将复杂对象的构建过程与表示分离，使同样的构建过程可以创建不同的对象。
    ///
    /// 结构:
    /// Director（指挥者）
    /// ↓
    /// Builder（建造者）
    /// ↓
    /// ConcreteBuilder（具体建造者）
    /// ↓
    /// Product（产品）
    /// 
    /// 注意:
    /// 一步一步构建对象, 而不是一次性 new 出来
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
        Console.WriteLine("\n使用建造者模式的代码:");
    }
}