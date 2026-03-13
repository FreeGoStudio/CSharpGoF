using AbstractFactory.Builder;
using AbstractFactory.Factory;
using AbstractFactory.Unit;

namespace AbstractFactory;

/// <summary>
/// 抽象工厂模式（Abstract Factory Pattern）
/// 是一种 创建型设计模式。
/// 
/// 核心思想:
/// 提供一个接口，用于创建“一系列相关或相互依赖的对象”，而无需指定它们的具体类。
/// 
/// 注意:
/// 抽象工厂的本意是“创建一组对象”，而不是“组装对象”
/// 抽象工厂在现实项目里其实用得不算多。
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

        Console.WriteLine("玩家游玩一个RTS游戏, 选择了人类种族。");
        Console.WriteLine("玩家建造人族兵营");
        var humanBarracks = new HumanBarracks();
        humanBarracks.BuildComplete();

        Console.WriteLine("玩家生产了3个人族弓箭手");
        var archer = new HumanArcher();
        var archer2 = new HumanArcher();
        var archer3 = new HumanArcher();

        Console.WriteLine("玩家带着他的部队选择冲锋敌方基地");
        archer.Attack();
        archer2.Attack();
        archer3.Attack();

        Console.WriteLine("玩家被兽人的高防战士一顿爆锤");
        Console.WriteLine("玩家失败了, 重新开始游戏");

        Console.WriteLine("玩家选择了兽人种族。");
        Console.WriteLine("玩家建造兽人兵营");
        var orcBarracks = new OrcBarracks();
        orcBarracks.BuildComplete();

        Console.WriteLine("玩家生产了3个兽人战士");
        var orcWarrior = new OrcWarrior();
        var orcWarrior2 = new OrcWarrior();
        var orcWarrior3 = new OrcWarrior();

        Console.WriteLine("玩家带着他的部队选择冲锋敌方基地");
        orcWarrior.Attack();
        orcWarrior2.Attack();
        orcWarrior3.Attack();

        Console.WriteLine("玩家被精灵的高魔攻法师打的满头包");
        Console.WriteLine("玩家失败了, 重新开始游戏");

        Console.WriteLine("玩家选择了精灵种族。");
        Console.WriteLine("玩家建造精灵法师塔");
        var elfMageTower = new ElfMageTower();
        elfMageTower.BuildComplete();

        Console.WriteLine("玩家生产了3个精灵法师");
        var elfMage = new ElfMage();
        var elfMage2 = new ElfMage();
        var elfMage3 = new ElfMage();

        Console.WriteLine("玩家带着他的部队选择冲锋敌方基地");
        elfMage.Attack();
        elfMage2.Attack();
        elfMage3.Attack();

        Console.WriteLine("玩家的脆皮法师被人族弓箭手一箭一个");
        Console.WriteLine("玩家失败了, 垃圾游戏, 删了");
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用抽象工厂模式的代码:");

        Console.WriteLine("玩家游玩一个RTS游戏, 选择了人类种族。");
        var humanFactory = new HumanFactory();

        Console.WriteLine("玩家建造人族兵营");
        var humanBarracks = humanFactory.CreateBarracks();
        humanBarracks.BuildComplete();

        Console.WriteLine("玩家生产了3个人族弓箭手");
        var archer = humanBarracks.CreateArcher();
        var archer2 = humanBarracks.CreateArcher();
        var archer3 = humanBarracks.CreateArcher();


        Console.WriteLine("玩家带着他的部队选择冲锋敌方基地");
        archer.Attack();
        archer2.Attack();
        archer3.Attack();

        Console.WriteLine("玩家被兽人的高防战士一顿爆锤");
        Console.WriteLine("玩家失败了, 重新开始游戏");

        Console.WriteLine("玩家选择了兽人种族。");
        var orcFactory = new OrcFactory();
        Console.WriteLine("玩家建造兽人兵营");
        var orcBarracks = orcFactory.CreateBarracks();
        orcBarracks.BuildComplete();

        Console.WriteLine("玩家生产了3个兽人战士");
        var orcWarrior = orcBarracks.CreateWarrior();
        var orcWarrior2 = orcBarracks.CreateWarrior();
        var orcWarrior3 = orcBarracks.CreateWarrior();

        Console.WriteLine("玩家带着他的部队选择冲锋敌方基地");
        orcWarrior.Attack();
        orcWarrior2.Attack();
        orcWarrior3.Attack();

        Console.WriteLine("玩家被精灵的高魔攻法师打的满头包");
        Console.WriteLine("玩家失败了, 重新开始游戏");

        Console.WriteLine("玩家选择了精灵种族。");
        var elfFactory = new ElfFactory();
        Console.WriteLine("玩家建造精灵法师塔");
        var elfMageTower = elfFactory.CreateMageTower();
        elfMageTower.BuildComplete();

        Console.WriteLine("玩家生产了3个精灵法师");
        var elfMage = elfFactory.CreateMage();
        var elfMage2 = elfFactory.CreateMage();
        var elfMage3 = elfFactory.CreateMage();

        Console.WriteLine("玩家带着他的部队选择冲锋敌方基地");
        elfMage.Attack();
        elfMage2.Attack();
        elfMage3.Attack();

        Console.WriteLine("玩家的脆皮法师被人族弓箭手一箭一个");
        Console.WriteLine("玩家失败了, 垃圾游戏, 删了");
    }
}