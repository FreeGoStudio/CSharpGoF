namespace TemplateMethod;

public class MagicAttackNew : AttackAction
{
    protected override void DoDamage()
    {
        Console.WriteLine("魔法造成30点伤害");
    }
}