namespace AbstractFactory;

/// <summary>
/// ICharacterFactory接口，定义了创建角色和天赋的方法。
/// 抽象工厂模式用于创建相关对象的家族，而无需指定具体类。
/// </summary>
public interface ICharacterFactory
{
    /// <summary>
    /// 创建角色天赋对象。
    /// </summary>
    /// <returns>返回ITalent类型的天赋对象。</returns>
    ITalent CreateTalent();

    /// <summary>
    /// 创建角色对象。
    /// </summary>
    /// <returns>返回ICharacter类型的角色对象。</returns>
    ICharacter CreateCharacter();
}