namespace AbstractFactory.Unit;

public class HumanArcher : IUnit
{
    public void Attack()
    {
        Console.WriteLine("人类弓箭手攻击！");
    }
}