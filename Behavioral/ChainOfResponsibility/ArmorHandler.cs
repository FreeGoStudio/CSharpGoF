namespace ChainOfResponsibility;

/// <summary>
/// ArmorHandler 处理角色的护甲伤害部分。
/// 仅对物理伤害生效，减少伤害值后传递到下一个处理器。
/// </summary>
public class ArmorHandler : DamageHandler
{
    /// <summary>
    /// 处理护甲逻辑。仅对物理伤害生效。
    /// </summary>
    /// <param name="damage">伤害对象</param>
    public override void Handle(DamageNew damage)
    {
        // 非物理伤害不处理，直接返回
        if (damage.Type != DamageType.Physical)
        {
            return;
        }

        var target = damage.Target;

        // 用护甲减少伤害
        damage.Value -= target.Armor;
        if (damage.Value < 0)
        {
            damage.Value = 0;
        }

        // 继续传递到下一个处理器
        base.Handle(damage);
    }
}