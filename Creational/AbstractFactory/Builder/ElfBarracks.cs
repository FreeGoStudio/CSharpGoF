using AbstractFactory.Factory;
using AbstractFactory.Unit;

namespace AbstractFactory.Builder;

public class ElfBarracks : IBarracks
{
    private IRaceFactory _factory;

    public ElfBarracks()
    {
        _factory = new ElfFactory();
    }

    public ElfBarracks(IRaceFactory factory)
    {
        _factory = factory;
    }

    public void BuildComplete()
    {
        Console.WriteLine("精灵兵营建造完成");
    }

    public IUnit CreateWarrior()
    {
        Console.WriteLine("精灵兵营生产了一个精灵战士");

        //return new ElfWarrior(); //如果没有使用抽象工厂模式，这里就需要直接依赖具体的精灵战士类，违反了依赖倒置原则。

        // 通过引入抽象工厂模式
        return _factory.CreateWarrior();
    }

    public IUnit CreateArcher()
    {
        Console.WriteLine("精灵兵营生产了一个精灵弓箭手");

        //return new ElfArcher(); //如果没有使用抽象工厂模式，这里就需要直接依赖具体的精灵弓箭手类，违反了依赖倒置原则。
        return _factory.CreateArcher();
    }
}