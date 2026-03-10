using AbstractFactory.Factory;
using AbstractFactory.Unit;

namespace AbstractFactory.Builder;

public class OrcMageTower : IMageTower
{
    private IRaceFactory _factory;

    public OrcMageTower()
    {
        _factory = new OrcFactory();
    }

    public OrcMageTower(IRaceFactory factory)
    {
        _factory = factory;
    }

    public void BuildComplete()
    {
        Console.WriteLine("兽人法师塔建造完成!");
    }

    public IUnit CreateMage()
    {
        Console.WriteLine("兽人法师塔生产了一个兽人法师");

        // return new OrcMage(); //如果没有使用抽象工厂模式，这里就需要直接依赖具体的兽人法师类，违反了依赖倒置原则。
        return _factory.CreateMage();
    }
}