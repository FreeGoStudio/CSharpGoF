using AbstractFactory.Unit;

namespace AbstractFactory;

/// <summary>
/// 法师塔接口，定义了创建法师的方法。
/// 用于抽象法师塔建筑的功能。
/// </summary>
public interface IMageTower : IBuilder
{
    /// <summary>
    /// 创建法师单位。
    /// </summary>
    /// <returns>精灵法师实例。</returns>
    IUnit CreateMage();
}