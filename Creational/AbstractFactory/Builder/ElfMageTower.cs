using AbstractFactory.Factory;
using AbstractFactory.Unit;

namespace AbstractFactory.Builder;

public class ElfMageTower : IMageTower
{
    private IRaceFactory _factory;

    public ElfMageTower()
    {
        _factory = new ElfFactory();
    }

    public ElfMageTower(IRaceFactory factory)
    {
        _factory = factory;
    }

    public void BuildComplete()
    {
        Console.WriteLine("精灵法师塔建造完成!");
    }

    public IUnit CreateMage()
    {
        Console.WriteLine("精灵法师塔生产了一个精灵法师");

        //return new ElfMage(); //如果没有使用抽象工厂模式，这里就需要直接依赖具体的精灵法师类，违反了依赖倒置原则。
        return _factory.CreateMage();
    }
}