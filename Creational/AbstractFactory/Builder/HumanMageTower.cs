using AbstractFactory.Factory;
using AbstractFactory.Unit;

namespace AbstractFactory.Builder;

public class HumanMageTower : IMageTower
{
    private IRaceFactory _factory;

    public HumanMageTower()
    {
        _factory = new HumanFactory();
    }

    public HumanMageTower(IRaceFactory factory)
    {
        _factory = factory;
    }

    public void BuildComplete()
    {
        Console.WriteLine("人类法师塔建造完成!");
    }

    public IUnit CreateMage()
    {
        Console.WriteLine("人类法师塔生产了一个人类法师");

        //return new HumanMage(); //如果没有使用抽象工厂模式，这里就需要直接依赖具体的人类法师类，违反了依赖倒置原则。
        return _factory.CreateMage();
    }
}