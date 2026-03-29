namespace ChainOfResponsibility;

/// <summary>
/// ShieldHandler 处理角色的护盾伤害部分。
/// 如果护盾大于0，则先用护盾吸收伤害，剩余伤害传递到下一个处理器。
/// </summary>
public class ShieldHandler : DamageHandler
{
    /// <summary>
    /// 处理护盾逻辑。如果护盾为0，则直接传递给下一个处理器。
    /// </summary>
    /// <param name="damage">伤害对象</param>
    public override void Handle(DamageNew damage)
    {
        var target = damage.Target;

        // 如果护盾为0，直接传递到下一个处理器
        if (target.Shield <= 0)
        {
            base.Handle(damage);
            return;
        }

        // 用护盾吸收伤害
        damage.Value -= target.Shield;
        if (damage.Value < 0)
        {
            damage.Value = 0;
        }

        // 扣除护盾值
        target.Shield -= damage.Value;

        // 继续传递到下一个处理器
        base.Handle(damage);
    }
}