namespace SimpleFactory;

/// <summary>
/// 武器接口，所有武器必须实现Use方法
/// </summary>
public interface IWeapon
{
    /// <summary>
    /// 使用武器的行为（如攻击、施法等）
    /// </summary>
    void Use();
}