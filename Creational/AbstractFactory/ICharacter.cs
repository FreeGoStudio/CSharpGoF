namespace AbstractFactory;

/// <summary>
/// 角色接口，定义了角色的基本行为和属性。
/// </summary>
public interface ICharacter
{
    /// <summary>
    /// 使用角色天赋的方法
    /// </summary>
    public void UseTalent();

    /// <summary>
    /// 角色天赋属性
    /// </summary>
    ITalent? Talent { get; set; }
}