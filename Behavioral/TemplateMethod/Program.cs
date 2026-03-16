namespace TemplateMethod;

/// <summary>
/// 模板方法模式（Template Method Pattern）
/// 是一种 行为型设计模式。
/// 
/// 核心思想:
/// 在父类中定义算法流程，把某些步骤延迟到子类实现。
/// 
/// 注意:
/// 父类决定流程, 子类决定细节
///
/// 模板方法 = 继承改变行为
/// 策略模式 = 组合改变行为
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //未使用设计模式
        UnusedDesignPattern();

        //使用设计模式
        UsedDesignPattern();
    }

    private static void UnusedDesignPattern()
    {
        Console.WriteLine("\n未使用设计模式的代码:");

        //发动攻击的过程: 准备->造成伤害->播放动画
        Console.WriteLine("玩家发动剑攻击");
        var swordAttack = new SwordAttack();
        swordAttack.Prepare();
        swordAttack.DoDamage();
        swordAttack.PlayAnimation();

        Console.WriteLine("玩家装备法杖");
        Console.WriteLine("玩家发动魔法攻击");
        var magicAttack = new MagicAttack();
        magicAttack.Prepare();
        magicAttack.DoDamage();
        magicAttack.PlayAnimation();
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用模板方法模式的代码:");

        //发动攻击的过程: 准备->造成伤害->播放动画
        Console.WriteLine("玩家发动剑攻击");
        var swordAttack = new SwordAttackNew();
        swordAttack.Execute();

        Console.WriteLine("玩家装备法杖");
        Console.WriteLine("玩家发动魔法攻击");
        var magicAttack = new MagicAttackNew();
        magicAttack.Execute();
    }
}