using AbstractFactory.Builder;
using AbstractFactory.Unit;

namespace AbstractFactory.Factory;

public class OrcFactory : IRaceFactory
{
    public IUnit CreateArcher()
    {
        return new OrcArcher();
    }

    public IUnit CreateWarrior()
    {
        return new OrcWarrior();
    }

    public IUnit CreateMage()
    {
        return new OrcMage();
    }

    public IBarracks CreateBarracks()
    {
        return new OrcBarracks(this);
    }

    public IMageTower CreateMageTower()
    {
        return new OrcMageTower(this);
    }
}