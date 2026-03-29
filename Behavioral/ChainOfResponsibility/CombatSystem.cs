namespace ChainOfResponsibility;

/// <summary>
/// 战斗系统，负责通过责任链模式处理角色受到的伤害。
/// </summary>
public class CombatSystem
{
    // 责任链的起始处理器
    private readonly DamageHandler _pipeline;

    /// <summary>
    /// 构造函数，初始化责任链：护盾 -> 护甲 -> 生命值。
    /// </summary>
    public CombatSystem()
    {
        _pipeline = new ShieldHandler();
        _pipeline.SetNext(new ArmorHandler())
                 .SetNext(new HealthHandler());
    }

    /// <summary>
    /// 应用伤害，启动责任链处理流程。
    /// </summary>
    /// <param name="damage">待处理的伤害对象</param>
    public void ApplyDamage(DamageNew damage)
    {
        _pipeline.Handle(damage);
    }
}