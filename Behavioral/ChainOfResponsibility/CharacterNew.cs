namespace ChainOfResponsibility;

/// <summary>
/// CharacterNew 角色类，包含护甲、生命值和护盾属性。
/// 用于责任链模式下的伤害处理。
/// </summary>
public class CharacterNew
{
    /// <summary>
    /// 角色护甲值。
    /// </summary>
    public float Armor { get; set; }

    /// <summary>
    /// 角色生命值。
    /// </summary>
    public float Health { get; set; }

    // 角色护盾值（私有字段）
    private float _shield;

    /// <summary>
    /// 角色护盾属性，不能为负。
    /// </summary>
    public float Shield
    {
        get => _shield;
        set => _shield = value < 0 ? 0 : value;
    }

    /// <summary>
    /// 构造函数，初始化角色属性。
    /// </summary>
    /// <param name="health">初始生命值</param>
    /// <param name="armor">初始护甲值</param>
    /// <param name="shield">初始护盾值</param>
    public CharacterNew(float health, float armor, float shield)
    {
        Health = health;
        Armor = armor;
        Shield = shield;
    }

    /// <summary>
    /// 角色死亡时调用。
    /// </summary>
    public void Die()
    {
        Console.WriteLine("角色死了");
    }
}