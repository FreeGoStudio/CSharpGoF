using AbstractFactory.Factory;
using AbstractFactory.Unit;

namespace AbstractFactory.Builder;

public class HumanBarracks : IBarracks
{
    private IRaceFactory _factory;

    public HumanBarracks()
    {
        _factory = new HumanFactory();
    }

    public HumanBarracks(IRaceFactory factory)
    {
        _factory = factory;
    }

    public void BuildComplete()
    {
        Console.WriteLine("人类兵营建造完成!");
    }

    public IUnit CreateWarrior()
    {
        Console.WriteLine("人类兵营生产了一个人类战士");

        //return new HumanWarrior(); //如果没有使用抽象工厂模式，这里就需要直接依赖具体的人类战士类，违反了依赖倒置原则。
        return _factory.CreateWarrior();
    }

    public IUnit CreateArcher()
    {
        Console.WriteLine("人类兵营生产了一个人类弓箭手");

        //return new HumanArcher(); //如果没有使用抽象工厂模式，这里就需要直接依赖具体的人类弓箭手类，违反了依赖倒置原则。
        return _factory.CreateArcher();
    }
}