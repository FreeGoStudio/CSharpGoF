using AbstractFactory.Builder;
using AbstractFactory.Unit;

namespace AbstractFactory.Factory;

public class ElfFactory : IRaceFactory
{
    public IUnit CreateArcher()
    {
        return new ElfArcher();
    }

    public IUnit CreateWarrior()
    {
        return new ElfWarrior();
    }

    public IUnit CreateMage()
    {
        return new ElfMage();
    }

    public IBarracks CreateBarracks()
    {
        return new ElfBarracks(this);
    }

    public IMageTower CreateMageTower()
    {
        return new ElfMageTower(this);
    }
}