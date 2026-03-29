namespace ChainOfResponsibility;

/// <summary>
/// HealthHandler 处理角色的生命值扣减。
/// 伤害最终作用于生命值，若生命值小于等于0则角色死亡。
/// </summary>
public class HealthHandler : DamageHandler
{
    /// <summary>
    /// 处理生命值逻辑。
    /// </summary>
    /// <param name="damage">伤害对象</param>
    public override void Handle(DamageNew damage)
    {
        var target = damage.Target;

        // 扣除生命值
        target.Health -= damage.Value;
        Console.WriteLine($"角色当前生命值{target.Health}");
        if (target.Health <= 0)
        {
            // 生命值小于等于0，角色死亡
            target.Die();
        }

        // 继续传递到下一个处理器（通常为链尾）
        base.Handle(damage);
    }
}