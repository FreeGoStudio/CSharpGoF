namespace ChainOfResponsibility;

/// <summary>
/// 责任链模式（Chain of Responsibility Pattern）
/// 是一种 行为型设计模式。
/// 
/// 定义:
/// 将多个处理对象连接成一条链，请求沿着这条链传递，直到有一个对象处理它为止。
///
/// 核心思想：
/// 请求的发送者不需要知道谁会处理它。
/// 
/// 结构:
/// Client（请求发起者）
///     ↓
/// Handler1（处理者1）
///     ↓
/// Handler2（处理者2）
///     ↓
/// Handler3（处理者3）
///     ↓
/// ...（一直传递）
///
/// 结构角色:
/// | 角色             | 说明                     |
/// | --------------- | ---------------------- |
/// | Handler         | 抽象处理者，定义处理接口 + 持有下一个节点 |
/// | ConcreteHandler | 具体处理者，决定是否处理或传递        |
/// | Client          | 发起请求                   |
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

        var character = new Character(100, 10, 20);
        var damage = new Damage();
        damage.Value = 50;
        damage.Type = DamageType.Physical;

        character.HandleDamage(damage);
    }


    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用责任链模式的代码:");

        var character = new CharacterNew(100, 10, 20);
        var damage = new DamageNew(character, 50, DamageType.Physical);

        var combatSystem = new CombatSystem();
        combatSystem.ApplyDamage(damage);
    }
}