using AbstractFactory.Builder;
using AbstractFactory.Unit;

namespace AbstractFactory.Factory;

public class HumanFactory : IRaceFactory
{
    public IUnit CreateArcher()
    {
        return new HumanArcher();
    }

    public IUnit CreateWarrior()
    {
        return new HumanWarrior();
    }

    public IUnit CreateMage()
    {
        return new HumanMage();
    }

    public IBarracks CreateBarracks()
    {
        return new HumanBarracks(this);
    }

    public IMageTower CreateMageTower()
    {
        return new HumanMageTower(this);
    }
}