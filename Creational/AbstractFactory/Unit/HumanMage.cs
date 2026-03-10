namespace AbstractFactory.Unit;

public class HumanMage : IUnit
{
    public void Attack()
    {
        Console.WriteLine("人类法师攻击!");
    }
}