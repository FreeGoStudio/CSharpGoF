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
/// 
/// 代理模式（Proxy）和装饰器模式（Decorator）看起来非常像，这是设计模式里最容易混淆的一对。
/// 1. 结构几乎完全一样
/// 2. 两者本质都属于一种包装的设计模式
/// 3. 区别只在 “目的” 上
/// |            |   代理模式   |  装饰器模式  |
/// | ---------- | ---------- | ---------- |
/// | 目的        | 控制访问    | 增强功能    |
/// | 是否改变行为 | 通常不改变   | 会增加行为  |
/// | 对象数量    | 一般一个代理 | 可以无限叠加 |
/// | 关注点     | 访问控制     | 功能扩展    |
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

        Console.WriteLine("角色进入游戏世界");

        Console.WriteLine("角色附近有100米内有100个NPC, 创建每个NPC需要1秒");
        var npcs = new List<Npc>();
        for (var i = 0; i < 100; i++)
        {
            npcs.Add(new Npc());
        }

        Console.WriteLine("每帧需要执行NPC的Update方法");
        foreach (var npc in npcs)
        {
            npc.Update();
        }

        Console.WriteLine("这是一个巨大的开销");
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用代理模式的代码:");

        Console.WriteLine("角色进入游戏世界");

        Console.WriteLine("角色附近有100米内有100个NPC, 但只创建100个轻量级的代理NPC对象");
        Console.WriteLine("创建每个NPC需要1秒, 但只真正创建和执行附近10米内的NPC");
        //代理对象更新距离
        float updateDistance = 10;

        var npcs = new List<NpcProxy>();
        for (var i = 0; i < 100; i++)
        {
            npcs.Add(new NpcProxy(updateDistance));
        }

        Console.WriteLine("每帧需要执行NPC的Update方法");

        foreach (var npcProxy in npcs)
        {
            npcProxy.Update();
        }
    }
}