namespace ChainOfResponsibility;

/// <summary>
/// DamageNew 伤害对象，包含目标、伤害值和伤害类型。
/// 用于责任链模式下的伤害传递。
/// </summary>
public class DamageNew(CharacterNew target, float value, DamageType type)
{
    /// <summary>
    /// 伤害目标。
    /// </summary>
    public CharacterNew Target { get; set; } = target;

    /// <summary>
    /// 伤害值。
    /// </summary>
    public float Value { get; set; } = value;

    /// <summary>
    /// 伤害类型。
    /// </summary>
    public DamageType Type { get; set; } = type;
}