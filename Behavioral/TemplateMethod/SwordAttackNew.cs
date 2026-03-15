namespace TemplateMethod;

public class SwordAttackNew : AttackAction
{
    protected override void DoDamage()
    {
        Console.WriteLine("剑造成20点伤害");
    }
}