namespace AbstractFactory.Unit;

public class HumanWarrior : IUnit
{
    public void Attack()
    {
        Console.WriteLine("人类战士攻击!");
    }
}